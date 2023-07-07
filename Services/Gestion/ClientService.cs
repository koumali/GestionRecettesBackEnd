using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion
{
    public class ClientService : GenericDataService<Client>, IClient
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetClientsAgence(int id)
        {
            var listContrats = await _context.Contrats
                .Include(c => c.Client)
                .Where(c => c.Reservation.Vehicule.Agence.Id == id)
                .ToListAsync();
            var listClients = new List<Client>();
            listContrats.ForEach(c => listClients.Add(new Client
            {
                Id = c.IdClient,
                Adresse = c.Client.Adresse,
                Adresse2 = c.Client.Adresse2,
                Email = c.Client.Email,
                Ville = c.Client.Ville,
                ZipCode = c.Client.ZipCode,
                FirstName = c.Client.FirstName,
                LastName = c.Client.LastName,
                Tel = c.Client.Tel,
                PermisRecto = c.Client.PermisRecto,
                PermisVerso = c.Client.PermisVerso,
            }));
            return listClients.DistinctBy(c => new { c.FirstName, c.LastName, c.Email });
        }
    }
}