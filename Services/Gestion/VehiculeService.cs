using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class VehiculeService : GenericDataService<Vehicule>, IVehicule
    {
        private readonly AppDbContext _context;

        public VehiculeService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<Vehicule> CreateAsync(Vehicule entity)
        {
            await _context.Vehicules.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _context.Vehicules
                .Include(v => v.Agence)
                .Include(v => v.Modele)
                .ThenInclude(m => m.Marque)
                .Where(v => v.Id == entity.Id)
                .FirstOrDefaultAsync();
        }

        public new async Task<Vehicule> UpdateAsync(Vehicule entity)
        {
            _context.Vehicules.Update(entity);
            await _context.SaveChangesAsync();
            return await _context.Vehicules
                .Include(v => v.Agence)
                .Include(v => v.Modele)
                .ThenInclude(m => m.Marque)
                .Where(v => v.Id == entity.Id)
                .FirstOrDefaultAsync();
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
                    Image = v.Image,
                    Gearbox = v.Gearbox,
                    Moteur = v.Moteur,
                    IdAgence = v.IdAgence,
                    IdModele = v.IdModele,
                    Modele = new Modele
                    {
                        Id = v.Modele.Id,
                        Name = v.Modele.Name,
                        Marque = v.Modele.Marque,
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
                .Where(v => v.Modele.Marque.Name == name)
                .ToListAsync();
        }

        // get top reserved vehicules
        public async Task<IEnumerable<Vehicule>> GetTopReservedVehicules(int number)
        {
            var topReservation = await _context.Reservations
                .Include(r => r.Vehicule)
                .GroupBy(r => r.IdVehicule)
                .Take(number).ToListAsync();

            return topReservation.Select(res => res.Select(r => r.Vehicule)
                    .FirstOrDefault()).Where(vehicule => vehicule != null)
                .ToList();
        }
    }
}