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

        public async Task<List<Contrat>> GetClientsAgence(int id)
        {
            return await _context.Contrats.Where(c => c.Reservation.Vehicule.Agence.Id == id).ToListAsync();
        }
    }
}