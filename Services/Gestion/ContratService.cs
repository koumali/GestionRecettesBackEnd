using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ContratService : GenericDataService<Contrat>, IContrat
    {
        private readonly AppDbContext _context;

        public ContratService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // public Contrat? add(Contrat Contrat)
        // {
        //     try
        //     {
        //         _context.Contrats.Add(Contrat);
        //         _context.SaveChanges();
        //         return Contrat;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
        //
        //
        // public Contrat? findById(int id)
        // {
        //     var Contrat = _context.Contrats.Where(u => u.id == id).FirstOrDefault();
        //     return Contrat;
        // }
        //
        //
        public new async Task<IEnumerable<Contrat>> GetAllAsync()
        {
            return await _context.Contrats                
                .Include(c => c.Client)
                .Include(r => r.Reservation)
                .ToListAsync();
        }
        // public IEnumerable<Contrat> getContrats()
        // {
        //     return _context.Contrats.Include(c => c.Client).ToList();
        // }
        //
        // public void delete(int id)
        // {
        //     var Contrat = _context.Contrats.Find(id);
        //     if (Contrat != null)
        //     {
        //         _context.Contrats.Remove(Contrat);
        //         _context.SaveChanges();
        //     }
        // }
        //
        // public Contrat update(Contrat updatedContrat)
        // {
        //     try
        //     {
        //         _context.Contrats.Update(updatedContrat);
        //         _context.SaveChanges();
        //         return updatedContrat;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
    }
}