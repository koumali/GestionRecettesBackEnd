using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IOffre : IGenericData<Offre>
    {
        Task<IEnumerable<Offre>> GetOffresAgence(int idAgence);
        // Offre? findById(int id);
        // Offre? add(Offre Offre);
        // void delete(int id);
        // Offre? update(Offre Offre);
    }
}