using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IOffre : IGenericData<Offre>
    {
        Task<IEnumerable<Offre>> GetOffresAgence(int idAgence);
        Task<IEnumerable<Offre>> GetPublicOffres(string type, string name, DateTime datedebut, DateTime datefin);
        Task<Offre?> GetPublicByIdAsync(int id);

        Task<Offre?> CreateWithDetailsAsync(OffreDto entity);
        Task<Offre?> UpdateWithDetailsAsync(OffreDto entity);

    }
}