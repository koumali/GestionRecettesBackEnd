using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IModele :  IGenericData<Modele>
    {
        Task<IEnumerable<Modele>> GetModelesAgence(int idAgence);
        // Modele? findById(int id);
        // Modele? add(Modele Modele);
        // void delete(int id);
        // Modele? update(Modele Modele);
    }
}