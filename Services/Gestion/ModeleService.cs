using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ModeleService : GenericDataService<Modele>, IModele
    {
        private readonly AppDbContext _context;

        public ModeleService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<Modele> CreateAsync(Modele entity)
        {
            await _context.Modeles.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _context.Modeles
                .Include(m => m.Marque)
                .FirstOrDefaultAsync(m => m.Id == entity.Id);
        }

        public new async Task<IEnumerable<Modele>> GetAllAsync()
        {
            return await _context.Modeles
                .Where(t => t.DeletedAt == null)
                .Include(o => o.Marque)
                .ToListAsync();
        }

        public async Task<IEnumerable<Modele>> GetModelesAgence(int idAgence)
        {
            var listVehicules = await _context.Vehicules
                .Where(t => t.DeletedAt == null)
                .Include(m => m.Modele)
                .ThenInclude(o => o.Marque)
                .Where(v => v.IdAgence == idAgence)
                .ToListAsync();
            var listModels = new List<Modele>();
            listVehicules.ForEach(v => listModels.Add(new Modele
            {
                Id = v.Modele.Id,
                Name = v.Modele.Name,
                IdMarque = v.Modele.IdMarque,
                Marque = v.Modele.Marque
            }));
            return listModels.DistinctBy(m => m.Name);
        }
    }
}