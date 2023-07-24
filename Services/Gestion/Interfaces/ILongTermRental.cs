using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface ILongTermRental : IGenericData<LongTermRental>
    {
        Task<LongTermRental?> GererMaReservation(string numero, string email);
        Task<LongTermRental> GetByIdAsync(int id);
        Task<IEnumerable<LongTermRental>> GetAllAsync();
        Task<LongTermRental> UpdateAsync(LongTermRental entity);
        // LongTermRental? add(LongTermRental LongTermRental);
        // void delete(int id);
        // LongTermRental? update(LongTermRental LongTermRental);
    }
}