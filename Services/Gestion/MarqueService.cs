using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class MarqueService : GenericDataService<Marque>, IMarque
    {
        private readonly AppDbContext _context;

        public MarqueService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Marque>> GetMarquesAgence(int idAgence)
        {
            var listVehicules = await _context.Vehicules
                .Where(t => t.DeletedAt == null)
                .Include(m => m.Modele)
                .ThenInclude(m => m.Marque)
                .Where(v => v.IdAgence == idAgence)
                .ToListAsync();
            var listMarques = new List<Marque>();
            listVehicules.ForEach(v => listMarques.Add(new Marque
            {
                Id = v.Modele.Marque.Id,
                Name = v.Modele.Marque.Name,
            }));
            return listMarques.DistinctBy(m => m.Name);
        }
    }
}