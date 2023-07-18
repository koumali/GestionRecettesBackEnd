using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
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
    }
}