using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AutomotiveApi.Services.Gestion
{
    public class ClientService : GenericDataService<Client>, IClient
    {
        private readonly AppDbContext _context;
        private readonly IFileHelper _fileHelper;
        private readonly IMapper _mapper;

        public ClientService(AppDbContext context, IFileHelper fileHelper, IMapper mapper) : base(context)
        {
            _context = context;
            _fileHelper = fileHelper;
            _mapper = mapper;
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
                PermisVerso = c.Client.PermisVerso
            }));
            return listClients.DistinctBy(c => new { c.FirstName, c.LastName, c.Email });
        }

        public async Task<Client?> GetClientByEmail(string email)
        {
            return await _context.Clients.Where(c => c.Email == email).FirstOrDefaultAsync();
        }


        public async Task<Client> AddAsync(ClientDto client)
        {
            Console.WriteLine("CreateAsync");
            // Console log serialize object
            Console.WriteLine(JsonConvert.SerializeObject(client));

            Client newClient = _mapper.Map<Client>(client);

            if (client.PermisRecto != null && client.PermisVerso != null)
            {
                newClient.PermisRecto = await _fileHelper.UploadImage(client.PermisRecto, "Permis");
                newClient.PermisVerso = await _fileHelper.UploadImage(client.PermisVerso, "Permis");
            }

            return await base.CreateAsync(newClient);
        }
    }
}