using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IReservation :  IGenericData<Reservation>
    {
        Task<IEnumerable<Reservation>> GetReservationsAgence(int idAgence);
        // Reservation? findById(int id);
        // Reservation? add(Reservation Reservation);
        // void delete(int id);
        // Reservation? update(Reservation Reservation);
    }
}