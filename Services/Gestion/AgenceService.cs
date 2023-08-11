using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

public class AgenceService : GenericDataService<Agence>, IAgence
{
    private readonly AppDbContext _context;

    public AgenceService(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<string?>> GetAllVilleAsync()
    {
        return await _context.Agences.Select(a => a.City).Distinct().ToListAsync();
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
}