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
                .Include(r => r.Vehicule)
                .ToListAsync();
            return reservations;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsAgence(int idAgence)
        {
            return await _context.Reservations
                .Include(r => r.Vehicule)
                .Where(r => r.Vehicule.Agence.Id == idAgence)
                .ToListAsync();
        }

        public async Task<Reservation?> GererMaReservation(string numero, string email)
        {
            var reservation = await _context.Reservations.Where(r => r.NumeroReservation == numero)
                .FirstOrDefaultAsync();
            // return reservation
            return reservation;
        }
    }
}