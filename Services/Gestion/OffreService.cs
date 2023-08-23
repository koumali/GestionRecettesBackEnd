using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Core;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

public class OffreService : GenericDataService<Offre>, IOffre
{
    private readonly AppDbContext _context;

    public OffreService(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Offre?> CreateWithDetailsAsync(OffreDto entity)
    {
        var offre = new Offre
        {
            DateDebut = entity.DateDebut,
            DateFin = entity.DateFin,
            Prix = entity.Prix,
            isPublic = entity.isPublic,
            IdVehicule = entity.IdVehicule
        };

        offre.OffreDetails = new List<OffreDetail>();

        foreach (var detail in entity.OffreDetails)
        {
            offre.OffreDetails.Add(new OffreDetail
            {

                Titre = detail.Titre,
                Description = detail.Description
            });
        }

        await base.CreateAsync(offre);

        return await GetByIdAsync(offre.Id);
    }

    public async Task<Offre> UpdateWithDetailsAsync(OffreDto entity)
    {
        Offre offre = await GetByIdAsync(entity.Id ?? 0);

        offre.DateDebut = entity.DateDebut;
        offre.DateFin = entity.DateFin;
        offre.Prix = entity.Prix;
        offre.isPublic = entity.isPublic;
        offre.IdVehicule = entity.IdVehicule;

        _context.OffreDetails.RemoveRange(offre.OffreDetails);

        offre.OffreDetails = new List<OffreDetail>();

        foreach (var detail in entity.OffreDetails)
        {
            offre.OffreDetails.Add(new OffreDetail
            {
                Id = detail.Id ?? 0,
                Titre = detail.Titre,
                Description = detail.Description
            });
        }


        await base.UpdateAsync(offre);

        return await GetByIdAsync(offre.Id);
    }


    public async Task<IEnumerable<Offre>> GetOffresAgence(int idAgence)
    {
        return await _context.Offres
            .Where(o => o.Vehicule.Agence.Id == idAgence)
            .Include(o => o.Vehicule).ThenInclude(v => v.Modele)
            .Select(o => new Offre
            {
                Id = o.Id,
                DateDebut = o.DateDebut,
                DateFin = o.DateFin,
                Prix = o.Prix,
                isPublic = o.isPublic,
                Vehicule = new Vehicule
                {
                    Id = o.Vehicule.Id,
                    Matricule = o.Vehicule.Matricule,
                    IdAgence = o.Vehicule.IdAgence,
                    Modele = new Modele
                    {
                        Id = o.Vehicule.Modele.Id,
                        Name = o.Vehicule.Modele.Name,
                        Image = o.Vehicule.Modele.Image,
                        Marque = new Marque
                        {
                            Id = o.Vehicule.Modele.Marque.Id,
                            Name = o.Vehicule.Modele.Marque.Name
                        }
                    }
                }
            }).ToListAsync();
    }

    public new async Task<Offre?> GetByIdAsync(int id)
    {
        return await _context.Offres.Where(u => u.Id == id)
            .Include(o => o.Vehicule.Agence)
            .Include(o => o.Vehicule.Modele)
            .ThenInclude(m => m.Marque)
            .Include(o => o.OffreDetails)
            .FirstOrDefaultAsync();
        ;
    }


    public new async Task<IEnumerable<Offre>> GetAllAsync()
    {
        return await _context.Offres.Include(o => o.Vehicule.Agence)
            .Include(o => o.Vehicule.Modele)
            .ThenInclude(m => m.Marque)
            .ToListAsync();
    }

    public async Task<IEnumerable<Offre>> GetPublicOffres(string type, string name, DateTime datedebut, DateTime datefin)
    {

        return await _context.Offres
            .Where(o => o.isPublic && o.DateDebut <= datedebut && datefin <= o.DateFin &&
                        o.Vehicule.Agence.City == name && o.Vehicule.Type == type)
            .Include(o => o.Vehicule.Agence)
            .Include(o => o.Vehicule.Modele)
            .ThenInclude(m => m.Marque)
            .Select(o => new Offre
            {
                Id = o.Id,
                DateDebut = o.DateDebut,
                DateFin = o.DateFin,
                Prix = o.Prix,
                isPublic = o.isPublic,
                Vehicule = new Vehicule
                {
                    Id = o.Vehicule.Id,
                    Matricule = o.Vehicule.Matricule,
                    IdAgence = o.Vehicule.IdAgence,
                    Agence = new Agence
                    {
                        Id = o.Vehicule.Agence.Id,
                        Name = o.Vehicule.Agence.Name,
                        City = o.Vehicule.Agence.City,
                        Address = o.Vehicule.Agence.Address,
                        Tel = o.Vehicule.Agence.Tel,
                        Email = o.Vehicule.Agence.Email
                    },
                    Type = o.Vehicule.Type,
                    Gearbox=o.Vehicule.Gearbox,
                    Moteur=o.Vehicule.Moteur,
                    Modele = new Modele
                    {
                        Id = o.Vehicule.Modele.Id,
                        Name = o.Vehicule.Modele.Name,
                        Image = o.Vehicule.Modele.Image,
                        Marque = new Marque
                        {
                            Id = o.Vehicule.Modele.Marque.Id,
                            Name = o.Vehicule.Modele.Marque.Name
                        }
                    }
                }
            }).ToListAsync();

    }

    public async Task<Offre?> GetPublicByIdAsync(int id)
    {
        return await _context.Offres.Where(u => u.Id == id && u.isPublic)
            .Include(o => o.Vehicule.Agence)
            .Include(o => o.Vehicule.Modele)
            .ThenInclude(m => m.Marque).Include(o => o.OffreDetails)
            .FirstOrDefaultAsync();
        ;
    }
}