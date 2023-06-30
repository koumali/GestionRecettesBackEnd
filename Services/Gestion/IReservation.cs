using automotiveApi.Models;

namespace automotiveApi.Services.Gestion
{
    public interface IReservation
    {
        IEnumerable<Reservation> getReservations();
        Reservation? findById(int id);
        Reservation? add(Reservation Reservation);
        void delete(int id);
        Reservation? update(Reservation Reservation);

    }
}