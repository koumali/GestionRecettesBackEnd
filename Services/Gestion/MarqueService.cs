using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;

namespace AutomotiveApi.Services.Gestion
{
    public class MarqueService : GenericDataService<Marque>, IMarque
    {
        public MarqueService(AppDbContext context) : base(context)
        {
        }

        // public Marque? add(Marque Marque)
        // {
        //     try
        //     {
        //         _context.Marques.Add(Marque);
        //         _context.SaveChanges();
        //         return Marque;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
        //
        //
        // public Marque? findById(int id)
        // {
        //     var Marque = _context.Marques.Where(u => u.id == id).FirstOrDefault();
        //     return Marque;
        // }
        //
        //
        // public IEnumerable<Marque> getMarques()
        // {
        //     return _context.Marques.ToList();
        // }
        //
        // public void delete(int id)
        // {
        //     var Marque = _context.Marques.Find(id);
        //     if (Marque != null)
        //     {
        //         _context.Marques.Remove(Marque);
        //         _context.SaveChanges();
        //     }
        // }
        //
        // public Marque update(Marque updatedMarque)
        // {
        //     try
        //     {
        //         _context.Marques.Update(updatedMarque);
        //         _context.SaveChanges();
        //         return updatedMarque;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
    }
}