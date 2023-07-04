using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ModeleService : GenericDataService<Modele>, IModele
    {
        public ModeleService(AppDbContext context): base(context)
        {
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