using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class LLDResponsesService : GenericDataService<LLDResponse>, ILLDResponse
    {
        private readonly AppDbContext _context;

        public LLDResponsesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<LLDResponse> GetByIdAsync(int id)
        {
            return await _context.lld_responses.FirstOrDefaultAsync(m => m.Id == id);
        }

        public new async Task<LLDResponse> CreateAsync(LLDResponse entity)
        {

            await _context.lld_responses.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _context.lld_responses
                .FirstOrDefaultAsync(m => m.Id == entity.Id);
        }

        public new async Task<IEnumerable<LLDResponse>> GetAllAsync()
        {
            return await _context.lld_responses
                .ToListAsync();
        }

        
    }
}
