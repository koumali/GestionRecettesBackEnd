using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class OffreService : GenericDataService<Offre>, IOffre
    {
        private readonly AppDbContext _context;
        public OffreService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<IEnumerable<Offre>> GetAllAsync()
        {
            return await _context.Offres.Include(o => o.Vehicule).ToListAsync();
        }


        public async Task<IEnumerable<Offre>> GetOffresAgence(int idAgence)
        {
            return await _context.Offres
                .Include(o => o.Vehicule)
                .Where(o => o.Vehicule.Agence.Id == idAgence)
                .ToListAsync();

         public new async Task<Offre?> GetByIdAsync(int id)
         {
             return await _context.Offres.Where(u => u.Id == id)
                                        .Include(o=>o.Vehicule.Agence)
                                        .Include(o => o.Vehicule.Modele)
                                            .ThenInclude(m => m.Marque)
                                        .FirstOrDefaultAsync(); ;
         }
        
        
        public new async Task<IEnumerable<Offre>> GetAllAsync()
         {
             return await _context.Offres.Include(o => o.Vehicule.Agence)
                                          .Include(o => o.Vehicule.Modele)
                                              .ThenInclude(m => m.Marque)
                                          .ToListAsync();

        }
    }
}
