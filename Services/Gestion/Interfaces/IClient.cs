using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IClient :  IGenericData<Client>
    {
        Task<IEnumerable<Client>> GetClientsAgence(int id);
        // Client? findById(int id);
        // Client? add(Client client);
        // void delete(int id);
        // Client? update(Client client);
    }
}