using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ReservationService : GenericDataService<Reservation>, IReservation
    {
        private readonly AppDbContext _context;

        public ReservationService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            var reservations = await _context.Reservations
                .Where(t => t.DeletedAt == null)
                .Include(r => r.Vehicule)
                .ToListAsync();
            return reservations;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsAgence(int idAgence)
        {
            return await _context.Reservations
                .Where(t => t.DeletedAt == null)
                .Include(r => r.Vehicule)
                .Where(r => r.Vehicule.Agence.Id == idAgence)
                .ToListAsync();
        }
    }
}