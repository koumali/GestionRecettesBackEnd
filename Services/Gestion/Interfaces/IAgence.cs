using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IAgence : IGenericData<Agence>
    {
        Task<IEnumerable<string>> GetAllVilleAsync();
    }
}