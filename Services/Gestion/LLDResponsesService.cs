using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutomotiveApi.Services.Mail;

namespace AutomotiveApi.Services.Gestion
{
    public class LLDResponsesService : GenericDataService<LLDResponse>, ILLDResponse
    {
        private readonly AppDbContext _context;
        private readonly IMailService _mailService;

        public LLDResponsesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<LLDResponse> GetByIdAsync(int id)
        {
            return await _context.lld_responses.FirstOrDefaultAsync(m => m.Id == id);
        }

        public new async Task<LLDResponse?> CreateAsync(LLDResponse entity)
        {


            var addedEntity = await base.CreateAsync(entity);

            return addedEntity;


        }

        public new async Task<IEnumerable<LLDResponse>> GetAllAsync()
        {
            return await _context.lld_responses
                .ToListAsync();
        }

        public async Task<string?> GetEmailByIdAsync(int id)
        {
            var email = await _context.long_term_rentals
                .Where(m => m.Id == id)
                .Select(m => m.email)
                .FirstOrDefaultAsync();
            return email;
        }


    }
}
