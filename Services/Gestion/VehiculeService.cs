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

        public new async Task<IEnumerable<Vehicule>> GetAllAsync()
        {
            return await _context.Vehicules
                .Include(v => v.Agence)
                .Include(v => v.Modele)
                .ThenInclude(m => m.Marque)
                .ToListAsync();
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
    }
}