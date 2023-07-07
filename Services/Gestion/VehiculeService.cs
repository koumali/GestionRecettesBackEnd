using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class VehiculeService : GenericDataService<Vehicule>, IVehicule
    {
        private readonly AppDbContext _context;

        public VehiculeService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // public Vehicule? add(Vehicule Vehicule)
        // {
        //     try
        //     {
        //         _context.Vehicules.Add(Vehicule);
        //         _context.SaveChanges();
        //         return Vehicule;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
        //
        //
        // public Vehicule? findById(int id)
        // {
        //     var Vehicule = _context.Vehicules.Where(u => u.id == id).FirstOrDefault();
        //     return Vehicule;
        // }
        //
        public new async Task<IEnumerable<Vehicule>> GetAllAsync()
        {
            return await _context.Vehicules
                .Include(v => v.Agence)
                .Include(v => v.Modele)
                .ThenInclude(m => m.Marque)
                .ToListAsync();
        }
        // public IEnumerable<Vehicule> getVehicules()
        // {
        //     return _context.Vehicules.Include(v => v.Modele).ThenInclude(m => m.Marque).Include(v => v.Agence).ToList();
        // }
        //
        // public void delete(int id)
        // {
        //     var Vehicule = _context.Vehicules.Find(id);
        //     if (Vehicule != null)
        //     {
        //         _context.Vehicules.Remove(Vehicule);
        //         _context.SaveChanges();
        //     }
        // }
        //
        // public Vehicule update(Vehicule updatedVehicule)
        // {
        //     try
        //     {
        //         _context.Vehicules.Update(updatedVehicule);
        //         _context.SaveChanges();
        //         return updatedVehicule;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
    }
}