using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ModeleService : GenericDataService<Modele>, IModele
    {
        private readonly AppDbContext _context;

        public ModeleService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // public Modele? add(Modele modele)
        // {
        //     try
        //     {
        //         _context.Modeles.Add(modele);
        //         _context.SaveChanges();
        //         return modele;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
        //
        //
        // public Modele? findById(int id)
        // {
        //     var Modele = _context.Modeles.Where(u => u.id == id).FirstOrDefault();
        //     return Modele;
        // }
        //
        //
        public new async Task<IEnumerable<Modele>> GetAllAsync()
        {
            return await _context.Modeles.Include(o => o.Marque).ToListAsync();
        }
        // public IEnumerable<Modele> getModeles()
        // {
        //     return _context.Modeles.Include(o => o.Marque).ToList();
        // }
        //
        // public void delete(int id)
        // {
        //     var modele = _context.Modeles.Find(id);
        //     if (modele != null)
        //     {
        //         _context.Modeles.Remove(modele);
        //         _context.SaveChanges();
        //     }
        // }
        //
        // public Modele update(Modele updatedModele)
        // {
        //     try
        //     {
        //         _context.Modeles.Update(updatedModele);
        //         _context.SaveChanges();
        //         return updatedModele;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
    }
}