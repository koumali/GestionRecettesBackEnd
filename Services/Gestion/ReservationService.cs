using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ReservationService : IReservation
    {
        private readonly AppDbContext _context;

        public ReservationService(AppDbContext context)
        {
            _context = context;
        }

        public Reservation? add(Reservation Reservation)
        {
            try
            {
                _context.Reservations.Add(Reservation);
                _context.SaveChanges();
                return Reservation;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Reservation? findById(int id)
        {
            var Reservation = _context.Reservations.Where(r => r.id == id).FirstOrDefault();
            return Reservation;
        }


        public IEnumerable<Reservation> getReservations()
        {
            var reservations = _context.Reservations.Include(r => r.Vehicule).ToList();
            return reservations;
        }

        public void delete(int id)
        {
            var Reservation = _context.Reservations.Find(id);
            if (Reservation != null)
            {
                _context.Reservations.Remove(Reservation);
                _context.SaveChanges();
            }
        }

        public Reservation update(Reservation updatedReservation)
        {
            try
            {
                _context.Reservations.Update(updatedReservation);
                _context.SaveChanges();
                return updatedReservation;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}