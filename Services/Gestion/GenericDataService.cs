using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Core;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

public class GenericDataService<T> : IGenericData<T> where T : ModelBase, new()
{
    private readonly AppDbContext _db;

    public GenericDataService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _db.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _db.Set<T>().FindAsync(id);
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        entity.UpdatedAt = DateTime.Now;
        _db.Set<T>().Update(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _db.Set<T>().FindAsync(id);
        if (entity == null) return false;
        // _db.Set<T>().Remove(entity);
        entity.DeletedAt = DateTime.Now;
        await _db.SaveChangesAsync();
        return true;
    }
}