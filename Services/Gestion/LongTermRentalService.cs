using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class LongTermRentalService : GenericDataService<LongTermRental>, ILongTermRental
    {
        private readonly AppDbContext _context;

        public LongTermRentalService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<IEnumerable<LongTermRental>> GetAllAsync()
        {
            return await _context.long_term_rentals.Include(l=>l.LLDResponses).ToListAsync();
        }
    }
}