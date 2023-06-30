using automotiveApi.DAL;
using automotiveApi.Models;

namespace automotiveApi.Services.Gestion
{
    public class AgenceService : IAgence
    {
        private readonly AppDbContext _context;

        public AgenceService(AppDbContext context)
        {
            _context = context;
        }

        public Agence? add(Agence agence)
        {
            try
            {
                _context.Agences.Add(agence);
                _context.SaveChanges();
                return agence;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        

        public Agence? findById(int id)
        {
            var Agence = _context.Agences.Where(u => u.id == id).FirstOrDefault();
            return Agence;
        
    
        }


        public IEnumerable<Agence> getAgences()
        {
            return _context.Agences.ToList();
        }
        public void delete(int id)
        {
            var agence = _context.Agences.Find(id);
            if (agence != null)
            {
                _context.Agences.Remove(agence);
                _context.SaveChanges();
            }
        }
        public Agence update(Agence updatedAgence)
        {
            try
            {
                _context.Agences.Update(updatedAgence);
                _context.SaveChanges();
                return updatedAgence;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}