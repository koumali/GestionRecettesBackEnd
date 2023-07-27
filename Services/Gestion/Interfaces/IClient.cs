using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface IClient : IGenericData<Client>
    {
        Task<Client> AddAsync(ClientDto client);

        Task<Client> UpdateAsync(ClientDto client);
        Task<ClientLoginResponse> LoginAsync(string email, string password);

        Task<IEnumerable<Client>> GetClientsAgence(int id);

        Task<Client?> GetClientByEmail(string email);

        Task<Client> RegisterAsync(ClientRegisterDto client);
        Task<IEnumerable<Reservation>?> GetClientReservations(int id);
        Task<IEnumerable<LongTermRental>?> GetClientLLDReservations(int id);
    }
}