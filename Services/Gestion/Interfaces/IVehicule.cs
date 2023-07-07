using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IVehicule : IGenericData<Vehicule>
    {
        Task<IEnumerable<Vehicule>> GetVehiculesAgence(int idAgence);
        // Vehicule? findById(int id);
        // Vehicule? add(Vehicule Vehicule);
        // void delete(int id);
        // Vehicule? update(Vehicule Vehicule);
    }
}