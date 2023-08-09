using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface ILLDResponse : IGenericData<LLDResponse>
    {
        //Task<IEnumerable<LLDResponse>> GetLLDResponsesAgence(int idAgence);
        Task<string?> GetEmailByIdAsync(int id);
    }
}