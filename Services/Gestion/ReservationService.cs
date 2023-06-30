using automotiveApi.DAL;
using automotiveApi.Models;

namespace automotiveApi.Services.Gestion
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
            var Reservation = _context.Reservations.Where(u => u.id == id).FirstOrDefault();
            return Reservation;
        
    
        }


        public IEnumerable<Reservation> getReservations()
        {
            return _context.Reservations.ToList();
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