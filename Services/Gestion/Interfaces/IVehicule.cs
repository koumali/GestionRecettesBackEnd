using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IVehicule : IGenericData<Vehicule>
    {
        Task<IEnumerable<Vehicule>> GetVehiculesAgence(int idAgence);
        Task<IEnumerable<Vehicule>> GetVehiculesByMarque(string name);
        Task<IEnumerable<Vehicule>> GetTopReservedVehicules(int number);
        // Vehicule? findById(int id);
        // Vehicule? add(Vehicule Vehicule);
        // void delete(int id);
        // Vehicule? update(Vehicule Vehicule);
    }
}