using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

public class VehiculeService : GenericDataService<Vehicule>, IVehicule
{
    private readonly AppDbContext _context;

    public VehiculeService(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public new async Task<Vehicule> CreateAsync(Vehicule entity)
    {
        await base.CreateAsync(entity);
        return await GetByIdAsync(entity.Id);
    }

    // get vehicule by id
    public new async Task<Vehicule> GetByIdAsync(int id)
    {
        return await _context.Vehicules
            .Include(v => v.Agence)
            .Include(v => v.Modele)
            .ThenInclude(m => m.Marque)
            .Where(v => v.Id == id)
            .Select(v => new Vehicule
            {
                Id = v.Id,
                Name = v.Name,
                Matricule = v.Matricule,
                Prix = v.Prix,
                Agence = new Agence
                {
                    Id = v.Agence.Id,
                    Name = v.Agence.Name

                },
                NbPort = v.NbPort,
                NbPassager = v.NbPassager,
                Km = v.Km,
                Climat = v.Climat,
                Airbag = v.Airbag,
                Gearbox = v.Gearbox,
                Moteur = v.Moteur,
                IdAgence = v.IdAgence,
                IdModele = v.IdModele,
                Type = v.Type,
                Modele = new Modele

                {
                    Id = v.Modele.Id,
                    Name = v.Modele.Name,
                    Image = v.Modele.Image,
                    Marque = new Marque
                    {
                        Id = v.Modele.Marque.Id,
                        Name = v.Modele.Marque.Name,
                    },
                    IdMarque = v.Modele.IdMarque,
                }
            }).FirstOrDefaultAsync();
    }

    public new async Task<Vehicule> UpdateAsync(Vehicule entity)
    {
        await base.UpdateAsync(entity);
        return await GetByIdAsync(entity.Id);
    }

    public new async Task<IEnumerable<Vehicule>> GetAllAsync()
    {
        return await _context.Vehicules
            .Include(v => v.Agence)
            .Include(v => v.Modele)
            .ThenInclude(m => m.Marque)
            .Select(v => new Vehicule
            {
                Id = v.Id,
                Name = v.Name,
                Matricule = v.Matricule,
                Prix = v.Prix,
                Agence = v.Agence,
                NbPort = v.NbPort,
                NbPassager = v.NbPassager,
                Km = v.Km,
                Climat = v.Climat,
                Airbag = v.Airbag,
                Gearbox = v.Gearbox,
                Moteur = v.Moteur,
                IdAgence = v.IdAgence,
                IdModele = v.IdModele,
                Modele = new Modele
                {
                    Id = v.Modele.Id,
                    Name = v.Modele.Name,
                    Marque = new Marque
                    {
                        Id = v.Modele.Marque.Id,
                        Name = v.Modele.Marque.Name,
                    },
                    IdMarque = v.Modele.IdMarque,
                }
            }).ToListAsync();
    }

    public async Task<IEnumerable<Vehicule>> GetVehiculesAgence(int idAgence)
    {
        return await _context.Vehicules
            .Where(v => v.IdAgence == idAgence)
            .Include(v => v.Agence)
            .Include(v => v.Modele)
            .ThenInclude(m => m.Marque)
            .ToListAsync();
    }

    // get vehicules by marque
    public async Task<IEnumerable<Vehicule>> GetVehiculesByMarque(string name)
    {
        return await _context.Vehicules
            .Include(v => v.Modele)
            .ThenInclude(m => m.Marque)
            .Where(v => v.Modele.Marque.Name == name)
            .ToListAsync();
    }


    public IEnumerable<Vehicule> GetTopReservedVehicules(int number)
    {
        var topReservation = _context.Reservations
            .Include(r => r.Vehicule)
            .ThenInclude(v => v.Modele)
            .ThenInclude(m => m.Marque)
            .GroupBy(r => r.IdVehicule);

        var topVehicules = new List<Vehicule>();
        foreach (var group in topReservation)
        {
            var reservations = group.Select(r => r.Vehicule).ToList();
            topVehicules.AddRange(reservations);
        }

        // Now, you have a list of reservations for all vehicles, you might want to sort them
        // based on some criteria (e.g., the number of reservations), and return only the top ones.
        // For example, to get the top 'number' of reserved vehicles, you can do the following:

        // topVehicules = topVehicules.OrderByDescending(v => v.Reservations.Count).Take(number).ToList();

        return topVehicules;
    }
}