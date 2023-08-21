using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IAgence : IGenericData<Agence>
    {
        Task<Agence> AddAbonAsync(AgenceClientDto agence);
        Task<Agence> AddAsync(AgenceDto agence);
        Task<Agence> UpdateAsync(AgenceDto agence);
        Task<IEnumerable<string>> GetAllVilleAsync();
        Task<IEnumerable<string>> GetAllLogosAsync();
        Task<IEnumerable<dynamic>> GetAllAgencesAsync();
        Task<IEnumerable<Agence>> GetAllNotVerifiedAsync();
        Task<IEnumerable<Agence>> GetAgenceWithHisSubAgences(int id);
        bool CheckIfParentAgence(int id); 
    }
}