using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion
{
    public interface IVehicule
    {
        IEnumerable<Vehicule> getVehicules();
        Vehicule? findById(int id);
        Vehicule? add(Vehicule Vehicule);
        void delete(int id);
        Vehicule? update(Vehicule Vehicule);
    }
}