using automotiveApi.DAL;
using automotiveApi.Models;

namespace automotiveApi.Services.Gestion
{
    public class ModeleService : IModele
    {
        private readonly AppDbContext _context;

        public ModeleService(AppDbContext context)
        {
            _context = context;
        }

        public Modele? add(Modele modele)
        {
            try
            {
                _context.Modeles.Add(modele);
                _context.SaveChanges();
                return modele;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        

        public Modele? findById(int id)
        {
            var Modele = _context.Modeles.Where(u => u.id == id).FirstOrDefault();
            return Modele;
        
    
        }


        public IEnumerable<Modele> getModeles()
        {
            return _context.Modeles.ToList();
        }
        public void delete(int id)
        {
            var modele = _context.Modeles.Find(id);
            if (modele != null)
            {
                _context.Modeles.Remove(modele);
                _context.SaveChanges();
            }
        }
        public Modele update(Modele updatedModele)
        {
            try
            {
                _context.Modeles.Update(updatedModele);
                _context.SaveChanges();
                return updatedModele;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}