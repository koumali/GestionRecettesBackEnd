using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IContrat : IGenericData<Contrat>
    {
        // IEnumerable<Contrat> getContrats();
        // Contrat? findById(int id);
        // Contrat? add(Contrat Contrat);
        Task<Contrat> DeleteContrat(int id);
        // Contrat? update(Contrat Contrat);
    }
}