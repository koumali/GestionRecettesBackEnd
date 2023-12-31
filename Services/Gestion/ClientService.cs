using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using AutomotiveApi.Utility.Exceptions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AutomotiveApi.Services.Gestion;

public class ClientService : GenericDataService<Client>, IClient
{
    private readonly AppDbContext _context;
    private readonly IFileHelper _fileHelper;
    private readonly IMapper _mapper;
    private readonly IJwt _jwtService;

    public ClientService(AppDbContext context, IFileHelper fileHelper, IMapper mapper, IJwt jwtService
    ) : base(context)
    {
        _context = context;
        _fileHelper = fileHelper;
        _mapper = mapper;
        _jwtService = jwtService;
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
        
        newClient.PermisRecto = null;
        newClient.PermisVerso = null;

        newClient.CreatedAt = DateTime.Now;

        _context.Clients.Add(newClient);
        _context.SaveChanges();


        if (client.PermisRecto != null && client.PermisVerso != null)
        {
            newClient.PermisRecto =
                await _fileHelper.UploadImage(client.PermisRecto, "Permis/" + newClient.Id, "permisRecto");
            newClient.PermisVerso =
                await _fileHelper.UploadImage(client.PermisVerso, "Permis/" + newClient.Id, "permisVerso");
            _context.Clients.Update(newClient);
            _context.SaveChanges();
        }


        return newClient;
    }

    public async Task<Client> UpdateAsync(ClientDto request)
    {


        bool emailExist = await _context.Clients.Where(c => c.Email.ToLower() == request.Email.ToLower() && c.Id != request.Id && c.Password != null).AnyAsync();

        if (emailExist)
        {
            throw new EmailException("email deja existant");
        }

        Client? client = await _context.Clients.FindAsync(request.Id);

        if (client == null)
        {
            throw new EmailException("client introuvable");
        }

        if (request.PermisRecto != null)
        {
            client.PermisRecto =
                await _fileHelper.UploadImage(request.PermisRecto, "Permis/" + client.Id, "permisRecto");
        }

        if (request.PermisVerso != null)
        {
            client.PermisVerso =
                await _fileHelper.UploadImage(request.PermisVerso, "Permis/" + client.Id, "permisVerso");
        }

        client.FirstName = request.FirstName;
        client.LastName = request.LastName;
        client.Tel = request.Tel;
        client.Ville = request.Ville;
        client.ZipCode = request.ZipCode;
        client.Adresse = request.Adresse;
        client.Adresse2 = request.Adresse2;

        if (client.Email.ToLower() != request.Email.ToLower())
        {
            client.Email = request.Email;
            client.IsVerified = false;
        }

        var updatedClient = await base.UpdateAsync(client);
        return updatedClient;
    }

    public async Task<Client> RegisterAsync(ClientRegisterDto client)
    {
        Client newClient = _mapper.Map<Client>(client);
        newClient.Password = BCrypt.Net.BCrypt.HashPassword(client.Password);

        Client? isClient = await _context.Clients.Where(c => c.Email.ToLower() == client.Email.ToLower() && c.Password != null).FirstOrDefaultAsync();

        if (isClient != null)
        {
            throw new EmailException("client deja existant");
        }

        try
        {
            await base.CreateAsync(newClient);
        }
        catch (Exception ex)
        {
            throw new EmailException(ex.Message);
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

    public async Task<ClientLoginResponse> LoginAsync(string email, string password)
    {
        Client? client =
            await _context.Clients.Where(c => c.Email == email && c.Password != null).FirstOrDefaultAsync();

        if (client == null)
        {
            return null;
        }

        if (!BCrypt.Net.BCrypt.Verify(password, client.Password))
        {
            return null;
        }



        var genToken = _jwtService.generateClientToken(client);

        return new ClientLoginResponse
        {
            Token = genToken,
            Client = client
        };
    }

    public async Task<IEnumerable<LongTermRental>?> GetClientLLDReservations(int id)
    {
        var email = await _context.Clients.Where(c => c.Id == id).Select(c => c.Email).FirstOrDefaultAsync();
        if (email == null)
        {
            return null;
        }

        var reservations = await _context.long_term_rentals.Where(c => c.email == email)
            .Include(l => l.LLDResponses)
                .ThenInclude(lld => lld.PieceJointes)
             .Include(l => l.LLDResponses)
                .ThenInclude(l => l.Agence)
            .Include(lld => lld.Modele)
            .ToListAsync();
        return reservations;
    }

    public async Task<Client> ChangePasswordAsync(int id, ChangePasswordDto changePasswordDto)
    {
        Client? client = await _context.Clients.Where(c => c.Id == id && c.Password != null
        ).FirstOrDefaultAsync();

        if (client == null)
        {
            throw new EmailException("client introuvable");
        }

        if (!BCrypt.Net.BCrypt.Verify(changePasswordDto.CurrentPassword, client.Password))
        {
            throw new EmailException("mot de passe incorrect");
        }

        client.Password = BCrypt.Net.BCrypt.HashPassword(changePasswordDto.NewPassword);

        await base.UpdateAsync(client);

        return client;
    }
}