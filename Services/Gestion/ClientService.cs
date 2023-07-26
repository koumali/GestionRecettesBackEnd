using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Param;
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
        private readonly IUser _userService;

        public ClientService(AppDbContext context, IFileHelper fileHelper, IMapper mapper, IUser userService
        ) : base(context)
        {
            _context = context;
            _fileHelper = fileHelper;
            _mapper = mapper;
            _userService = userService;
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


            Client newClient = _mapper.Map<Client>(client);

            _context.Clients.Add(newClient);
            _context.SaveChanges();


            if (client.PermisRecto != null && client.PermisVerso != null)
            {
                newClient.PermisRecto = await _fileHelper.UploadImage(client.PermisRecto, "Permis/" + newClient.Id, "permisRecto");
                newClient.PermisVerso = await _fileHelper.UploadImage(client.PermisVerso, "Permis/" + newClient.Id, "permisVerso");
            }

            _context.Clients.Update(newClient);
            _context.SaveChanges();

            return newClient;
        }

        public async Task<Client> UpdateAsync(ClientDto request)
        {
            Client? client = await _context.Clients.FindAsync(request.Id);

            if (request.PermisRecto != null)
            {
                client.PermisRecto = await _fileHelper.UploadImage(request.PermisRecto, "Permis/" + client.Id, "permisRecto");
            }
            if (request.PermisVerso != null)
            {
                client.PermisVerso = await _fileHelper.UploadImage(request.PermisVerso, "Permis/" + client.Id, "permisVerso");
            }

            client.FirstName = request.FirstName;
            client.LastName = request.LastName;
            client.Tel = request.Tel;
            client.Email = request.Email;
            client.Ville = request.Ville;
            client.ZipCode = request.ZipCode;
            client.Adresse = request.Adresse;
            client.Adresse2 = request.Adresse2;

            var updatedClient = await base.UpdateAsync(client);
            return updatedClient;
        }

        public async Task<Client> RegisterAsync(ClientRegisterDto client)
        {
            Client newClient = _mapper.Map<Client>(client);

            Client? isClient = await GetClientByEmail(client.Email);

            if (isClient != null)
            {
                throw new Exception("Client already exist");
            }

            try
            {
                await base.CreateAsync(newClient);

                Role? clientRole = await _context.Roles.Where(r => r.Name == "Client").FirstOrDefaultAsync();

                User user = new User
                {
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    Email = client.Email,
                    Password = client.Password,
                    IdRole = clientRole != null ? clientRole.Id : 0,
                    clientId = newClient.Id
                };


                await _userService.CreateAsync(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return newClient;
        }

        public async Task<IEnumerable<Reservation>?> GetClientReservations(int id)
        {
            var reservations = await _context.Contrats.Where(c => c.IdClient == id && c.IsConducteur == false)
            .Include(c => c.Reservation)
            .ThenInclude(r => r.Vehicule)
            .ThenInclude(v => v.Agence)
            .Include(c => c.Reservation.Vehicule.Modele)
            .ThenInclude(m => m.Marque)
            .Select(c => c.Reservation)
            .ToListAsync();
            return reservations;

        }


    }
}