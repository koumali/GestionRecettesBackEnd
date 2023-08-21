using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

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
            .Where(r => r.Vehicule.Agence.Id == idAgence).Include(r => r.Contrats).ThenInclude(c => c.Client)
            .Select(r => new Reservation
            {
                Id = r.Id,
                DateDepart = r.DateDepart,
                DateRetour = r.DateRetour,
                Status = r.Status,
                NumeroReservation = r.NumeroReservation,
                CreatedAt = r.CreatedAt,
                MontantTotal = r.MontantTotal,
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
                },

                // get clients array from contrat
                Contrats = r.Contrats.Select(c => new Contrat
                {
                    Id = c.Id,
                    Client = new Client
                    {
                        Id = c.Client.Id,
                        FirstName = c.Client.FirstName,
                        LastName = c.Client.LastName,
                        Email = c.Client.Email,
                        Tel = c.Client.Tel
                    }
                }).ToList()
            }).ToListAsync();
    }


    public async Task<MaReservationDto> GererMaReservation(string numero, string email)
    {
        var reservation = await _context.Reservations
            .Include(r => r.Contrats)
            .ThenInclude(c => c.Client)
            .Include(r => r.Vehicule)
            .ThenInclude(v => v.Modele)
            .ThenInclude(m => m.Marque)
            .Where(r => r.NumeroReservation == numero)
            .FirstOrDefaultAsync();

        if (reservation == null) throw new Exception("reservation n'existe pas");

        var client = reservation.Contrats.Where(c => c.Client.Email == email).FirstOrDefault()?.Client;
        var newMaReservation = new MaReservationDto
        {
           CreatedAt = reservation.CreatedAt,
           Status = reservation.Status,
           DateDepart = reservation.DateDepart,
           DateRetour = reservation.DateRetour,
           ModelName = reservation.Vehicule.Modele.Name,
           MarqueName = reservation.Vehicule.Modele.Marque.Name,
           ClientName = $"{client?.FirstName} {client?.LastName}",
           NumeroReservation = reservation.NumeroReservation
        };
        return newMaReservation;
    }

    public new async Task<Reservation?> GetByIdAsync(int id)
    {
        Reservation? res = await _context.Reservations.Where(r => r.Id == id)
              .Include(r => r.Vehicule).ThenInclude(v => v.Modele)
              .Include(r => r.Contrats).ThenInclude(c => c.Client)
              .Select(r => new Reservation
              {
                  Id = r.Id,
                  DateDepart = r.DateDepart,
                  DateRetour = r.DateRetour,
                  Status = r.Status,
                  NumeroReservation = r.NumeroReservation,
                  MontantTotal = r.MontantTotal,
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
                  },

                  // get clients array from contrat
                  Contrats = r.Contrats.Select(c => new Contrat
                  {
                      Id = c.Id,
                      Client = new Client
                      {
                          Id = c.Client.Id,
                          FirstName = c.Client.FirstName,
                          LastName = c.Client.LastName,
                          Email = c.Client.Email,
                          Tel = c.Client.Tel
                      }
                  }).ToList()
              }).FirstOrDefaultAsync();

        return res;
    }

    public new async Task<Reservation> UpdateAsync(Reservation entity)
    {
        var reservation = await _context.Reservations.Where(r => r.Id == entity.Id).FirstOrDefaultAsync();
                  
        if (reservation is null) throw new Exception("Reservation not found");

        reservation.DateDepart = entity.DateDepart;
        reservation.DateRetour = entity.DateRetour;
        reservation.Status = entity.Status;
        reservation.MontantTotal = entity.MontantTotal;
        

        await _context.SaveChangesAsync();
        return reservation;
    }
}