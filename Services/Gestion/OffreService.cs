using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class OffreService : IOffre
    {
        private readonly AppDbContext _context;

        public OffreService(AppDbContext context)
        {
            _context = context;
        }

        public Offre? add(Offre Offre)
        {
            try
            {
                _context.Offres.Add(Offre);
                _context.SaveChanges();
                return Offre;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Offre? findById(int id)
        {
            var Offre = _context.Offres.Where(u => u.id == id).FirstOrDefault();
            return Offre;
        }


        public IEnumerable<Offre> getOffres()
        {
            return _context.Offres.Include(o => o.Vehicule).ToList();
        }

        public void delete(int id)
        {
            var Offre = _context.Offres.Find(id);
            if (Offre != null)
            {
                _context.Offres.Remove(Offre);
                _context.SaveChanges();
            }
        }

        public Offre update(Offre updatedOffre)
        {
            try
            {
                _context.Offres.Update(updatedOffre);
                _context.SaveChanges();
                return updatedOffre;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}