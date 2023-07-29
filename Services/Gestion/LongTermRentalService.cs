using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
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
            return await _context.long_term_rentals.Where(l => l.status == ReservationStatus.Enattente.ToString() && l.idAgence==null).Include(l => l.Modele).ThenInclude(m=>m.Marque).Include(l => l.LLDResponses).ToListAsync();
        }
        public new async Task<LongTermRental> GetByIdAsync(int id)
        {
            return await _context.long_term_rentals.Where(l => l.Id == id).Include(l => l.LLDResponses).FirstOrDefaultAsync();
        }
        public async Task<LongTermRental?> GererMaReservation(string numero, string email)
        {
            var longTermRental = await _context.long_term_rentals.Where(r => r.NumeroReservation == numero && r.email == email).Include(l => l.LLDResponses).ThenInclude(l => l.Agence).FirstOrDefaultAsync();
            return longTermRental;
        }
        public async Task<LongTermRental> UpdateAsync(LongTermRental entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _context.Set<LongTermRental>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

    }
}