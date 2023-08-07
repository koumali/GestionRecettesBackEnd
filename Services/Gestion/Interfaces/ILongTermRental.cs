using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface ILongTermRental : IGenericData<LongTermRental>
    {
        Task<LongTermRental?> GererMaReservation(string numero, string email);
        Task<LongTermRental?> CreateAsync(LongTermRental entity, List<int> selectedAgences);

        Task<LongTermRental> GetByIdAsync(int id);
        Task<IEnumerable<LongTermRental>> GetAllAsync();
        Task<IEnumerable<LongTermRental>> GetLongTermRentalsByAgence(int idAgence);
        Task<LongTermRental> UpdateAsync(LongTermRental entity);
        
        // LongTermRental? add(LongTermRental LongTermRental);
        // void delete(int id);
        // LongTermRental? update(LongTermRental LongTermRental);
    }
}