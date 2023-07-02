using automotiveApi.DAL;
using automotiveApi.Models;
using Microsoft.EntityFrameworkCore;

namespace automotiveApi.Services.Gestion
{
    public class ContratService : IContrat
    {
        private readonly AppDbContext _context;

        public ContratService(AppDbContext context)
        {
            _context = context;
        }

        public Contrat? add(Contrat Contrat)
        {
            try
            {
                _context.Contrats.Add(Contrat);
                _context.SaveChanges();
                return Contrat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        

        public Contrat? findById(int id)
        {
            var Contrat = _context.Contrats.Where(u => u.id == id).FirstOrDefault();
            return Contrat;
        
    
        }


        public IEnumerable<Contrat> getContrats()
        {
            return _context.Contrats.Include(c => c.Client).ToList();
        }
        public void delete(int id)
        {
            var Contrat = _context.Contrats.Find(id);
            if (Contrat != null)
            {
                _context.Contrats.Remove(Contrat);
                _context.SaveChanges();
            }
        }
        public Contrat update(Contrat updatedContrat)
        {
            try
            {
                _context.Contrats.Update(updatedContrat);
                _context.SaveChanges();
                return updatedContrat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}