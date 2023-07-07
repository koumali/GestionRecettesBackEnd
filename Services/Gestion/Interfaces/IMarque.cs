using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IMarque : IGenericData<Marque>
    {
        Task<IEnumerable<Marque>> GetMarquesAgence(int idAgence);
        // Marque? findById(int id);
        // Marque? add(Marque marque);
        // void delete(int id);
        // Marque? update(Marque marque);
    }
}