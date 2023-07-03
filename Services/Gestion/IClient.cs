using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion
{
    public interface IClient
    {
        IEnumerable<Client> getClients();
        Client? findById(int id);
        Client? add(Client client);
        void delete(int id);
        Client? update(Client client);
    }
}