using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IAgence : IGenericData<Agence>
    {
        Task<IEnumerable<string>> GetAllVilleAsync();
        Task<IEnumerable<dynamic>> GetAllAgencesAsync();
        Task<IEnumerable<Agence>> GetAllNotVerifiedAsync();
        Task<IEnumerable<Agence>> GetAgenceWithHisSubAgences(int id);
    }
}