using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
using AutomotiveApi.Utility.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

public class AgenceService : GenericDataService<Agence>, IAgence
{
    private readonly AppDbContext _context;
    private readonly IFileHelper _fileHelper;
    private readonly IMapper _mapper;

    public AgenceService(AppDbContext context, IFileHelper fileHelper,IMapper mapper) : base(context)
    {
        _context = context;
        _fileHelper = fileHelper;
        _mapper = mapper;
    }
    
    public async Task<Agence> AddAbonAsync(AgenceClientDto agence)
    {
        Agence newAgence = _mapper.Map<Agence>(agence);
        newAgence.CreatedAt = DateTime.Now;

        _context.Agences.Add(newAgence);
        _context.SaveChanges();


        if (agence.Logo != null)
        {
            newAgence.Logo = await _fileHelper.UploadImage(agence.Logo, "Logos/" + newAgence.Id, "logo");
            _context.Agences.Update(newAgence);
            _context.SaveChanges();
        }


        return newAgence;
    }
    public async Task<Agence> AddAsync(AgenceDto agence)
    {
        Agence newAgence = _mapper.Map<Agence>(agence);
        newAgence.CreatedAt = DateTime.Now;
        newAgence.IsVerified= true;

        _context.Agences.Add(newAgence);
        _context.SaveChanges();


        if (agence.Logo != null)
        {
            newAgence.Logo = await _fileHelper.UploadImage(agence.Logo, "Logos/" + newAgence.Id, "logo");
            _context.Agences.Update(newAgence);
            _context.SaveChanges();
        }


        return newAgence;
    }
    public async Task<IEnumerable<string?>> GetAllVilleAsync()
    {
        return await _context.Agences.Where(a => a.IsVerified && a.City != null)
            .Select(a => a.City).Distinct().ToListAsync();
    }
    public async Task<IEnumerable<string?>> GetAllLogosAsync()
    {
        return await _context.Agences.Where(a=>a.IsVerified).Select(a => a.Logo).Distinct().ToListAsync();
    }

    public async Task<IEnumerable<dynamic?>> GetAllAgencesAsync()
    {
        return await _context.Agences.Select(a => new { a.Id, a.Name }).ToListAsync();
    }

    // get all verified agences
    public new async Task<IEnumerable<Agence>> GetAllAsync()
    {
        return await _context.Agences.Where(a => a.IsVerified).ToListAsync();
    }

    // get all not verified agences
    public async Task<IEnumerable<Agence>> GetAllNotVerifiedAsync()
    {
        return await _context.Agences.Where(a => !a.IsVerified).ToListAsync();
    }

    public async Task<IEnumerable<Agence>> GetAgenceWithHisSubAgences(int id)
    {
        return await _context.Agences.Where(a => a.Id == id || a.ParentId == id)
            .ToListAsync();
    }

    public bool CheckIfParentAgence(int id)
    {
        return _context.Agences.Any(a => a.ParentId == id);
    }
    public async Task<Agence> UpdateAsync(AgenceDto request)
    {


        Agence? agence = await _context.Agences.FindAsync(request.Id);

        if (agence == null)
        {
            throw new EmailException("Agence introuvable");
        }

        if (request.Logo != null)
        {
            agence.Logo =
                await _fileHelper.UploadImage(request.Logo, "Logos/" + agence.Id, "logo");
        }


        agence.Name = request.Name;
        agence.Tel = request.Tel;
        agence.Email = request.Email;
        agence.Address = request.Address;
        agence.City = request.City;
        agence.ZipCode = request.ZipCode;
        agence.Latitude = request.Latitude;
        agence.Longitude = request.Longitude;
        agence.IsVerified = request.IsVerified;


        var updatedAgence = await base.UpdateAsync(agence);
        return updatedAgence;
    }
}