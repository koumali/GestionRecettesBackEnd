using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ReservationService : GenericDataService<Reservation>, IReservation
    {
        private readonly AppDbContext _context;

        public ReservationService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public new async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            var reservations = await _context.Reservations
                .Include(r => r.Vehicule)
                .ToListAsync();
            return reservations;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsAgence(int idAgence)
        {
            return await _context.Reservations
                .Include(r => r.Vehicule).ThenInclude(v => v.Modele)
                .Where(r => r.Vehicule.Agence.Id == idAgence)
                .Select(r => new Reservation
                {
                    Id = r.Id,
                    DateDepart = r.DateDepart,
                    DateRetour = r.DateRetour,
                    Status = r.Status,
                    NumeroReservation = r.NumeroReservation,
                    CreatedAt = r.CreatedAt,
                    Vehicule = new Vehicule
                    {
                        Id = r.Vehicule.Id,
                        Matricule = r.Vehicule.Matricule,
                        IdAgence = r.Vehicule.IdAgence,
                        Modele = new Modele
                        {
                            Id = r.Vehicule.Modele.Id,
                            Name = r.Vehicule.Modele.Name,
                            Image = r.Vehicule.Modele.Image,
                            Marque = new Marque
                            {
                                Id = r.Vehicule.Modele.Marque.Id,
                                Name = r.Vehicule.Modele.Marque.Name
                            }
                        }
                    }
                }).ToListAsync();
        }



        public async Task<Reservation?> GererMaReservation(string numero, string email)
        {
            var reservation = await _context.Reservations.Where(r => r.NumeroReservation == numero)
                .FirstOrDefaultAsync();
            // return reservation
            return reservation;
        }
    }
}