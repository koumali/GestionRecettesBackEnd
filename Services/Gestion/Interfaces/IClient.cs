using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IClient :  IGenericData<Client>
    {
        Task<Client> AddAsync(ClientDto client);
        Task<IEnumerable<Client>> GetClientsAgence(int id);
        // Client? findById(int id);
        // Client? add(Client client);
        // void delete(int id);
        // Client? update(Client client);
    }
}