using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IOffre : IGenericData<Offre>
    {
        Task<IEnumerable<Offre>> GetOffresAgence(int idAgence);
        Task<IEnumerable<Offre>> GetPublicOffres(string name, DateTime datedebut, DateTime datefin);
        Task<Offre?> GetPublicByIdAsync(int id);
        // Offre? findById(int id);
        // Offre? add(Offre Offre);
        // void delete(int id);
        // Offre? update(Offre Offre);
    }
}