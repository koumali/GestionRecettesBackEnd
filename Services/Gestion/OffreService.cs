using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class OffreService : GenericDataService<Offre>, IOffre
    {
        private readonly AppDbContext _context;
        public OffreService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<Offre> CreateAsync(Offre entity)
        {
            await _context.Offres.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _context.Offres.Include(o => o.Vehicule)
                .FirstOrDefaultAsync(o => o.Id == entity.Id);
        }

        public async Task<IEnumerable<Offre>> GetOffresAgence(int idAgence)
        {
            return await _context.Offres           
                .Include(o => o.Vehicule)
                .Where(o => o.Vehicule.Agence.Id == idAgence)
                .ToListAsync();
        }

        public new async Task<Offre?> GetByIdAsync(int id)
        {
            return await _context.Offres.Where(u => u.Id == id)
                                       .Include(o => o.Vehicule.Agence)
                                       .Include(o => o.Vehicule.Modele)
                                           .ThenInclude(m => m.Marque)
                                       .FirstOrDefaultAsync(); ;
        }


        public new async Task<IEnumerable<Offre>> GetAllAsync()
        {
            return await _context.Offres.Include(o => o.Vehicule.Agence)
                                        .Include(o => o.Vehicule.Modele)
                                             .ThenInclude(m => m.Marque)
                                         .ToListAsync();

        }

        public async Task<IEnumerable<Offre>> GetPublicOffres(string name, DateTime datedebut, DateTime datefin)
        {
            Console.WriteLine(datedebut);
            return await _context.Offres
                .Where(o => o.isPublic &&  o.DateDebut <= datedebut && datefin <= o.DateFin)
                //.Where(o => o.Vehicule.Agence.City == name) a inplmenter &
                .Include(o => o.Vehicule.Agence)
                             .Include(o => o.Vehicule.Modele)
                                              .ThenInclude(m => m.Marque)
                                          .ToListAsync();
        }

        public async Task<Offre?> GetPublicByIdAsync(int id)
        {
            return await _context.Offres.Where(u => u.Id == id  && u.isPublic)
                                       .Include(o => o.Vehicule.Agence)
                                       .Include(o => o.Vehicule.Modele)
                                           .ThenInclude(m => m.Marque)
                                       .FirstOrDefaultAsync(); ;
        }
    }
}
