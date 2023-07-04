using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Services.Gestion.Interfaces;

public interface IGenericData<T> where T : ModelBase, new()
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
}