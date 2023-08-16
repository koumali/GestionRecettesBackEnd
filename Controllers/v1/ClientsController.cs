using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Mail;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using AutomotiveApi.Utility.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutomotiveApi.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class ClientsController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IClient _clientService;
    private readonly IEmailVerification _emailVerificationService;
    private readonly IMailService _mailService;


    public ClientsController(IClient clientService, IMapper mapper, IEmailVerification emailVerificationService, IMailService mailService)
    {
        _clientService = clientService;
        _mapper = mapper;
        _emailVerificationService = emailVerificationService;
        _mailService = mailService;
    }


    [HttpGet("agence/{idAgence}")]
    [ValidatIdAgence("idAgence")]
    public async Task<ActionResult<IEnumerable<Client>>> GetClientsAgence(int idAgence)
    {
        var clients = await _clientService.GetClientsAgence(idAgence);
        return Ok(clients);
    }



    [HttpPost]
    public async Task<ActionResult<Client>> AddClient([FromForm] ClientDto request)
    {
        try
        {
            var addedClient = await _clientService.AddAsync(request);
            return Ok(addedClient);
        }
        catch (Exception ex)
        {
            return BadRequest(new { errors = ex.Message });
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetClientById(int id)
    {
        var client = await _clientService.GetByIdAsync(id);
        return Ok(client);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteClient(int id)
    {
        await _clientService.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Client>> UpdateClient(int id, [FromForm] ClientDto request)
    {
        if (id != request.Id)
        {
            return BadRequest(new { errors = "id non valide" });
        }

        Client? client = await _clientService.UpdateAsync(request);

        return Ok(client);
    }


    [HttpGet("infos")]
    // [Authorize(Roles = "Client")]
    public async Task<ActionResult<Client>> GetClientInfos()
    {
        int clientId = int.Parse(User.FindFirst("clientId")?.Value ?? "0");

        Client? client = await _clientService.GetByIdAsync(clientId);

        return Ok(client);
    }

    [HttpPost("register")]
    public async Task<ActionResult<Client>> RegisterClient(ClientRegisterDto request)
    {
        if (request.terms == false)
        {
            return BadRequest(new { errors = "vous devez accepter les conditions d'utilisation" });
        }

        try
        {
            var newClient = await _clientService.RegisterAsync(request);
            var token = await _emailVerificationService.GenerateVerificationToken(newClient.Email);
            var url = $"{Request.Scheme}://{Request.Host}/verify-email?token={token}";
            var mailData = new MailData
            {
                To = newClient.Email,
                Subject = "verification de l'email",
                Body = "Veuillez cliquer sur le lien ci-dessous pour vérifier votre adresse e-mail",
                url = url
            };

            await _mailService.SendAsync(mailData);

            return Ok(newClient);
        }

        catch (EmailException ex)
        {
            return BadRequest(new { errors = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { errors = "Erreur lors de l'ajout du client" });
        }
    }

    [HttpGet("reservations")]
    // [Authorize(Roles = "Client")]
    public async Task<ActionResult<IEnumerable<Reservation>>> GetClientReservations()
    {
        int clientId = int.Parse(User.FindFirst("clientId")?.Value ?? "0");

        var reservations = await _clientService.GetClientReservations(clientId);

        return Ok(reservations);
    }


    [HttpPost("login")]
    public async Task<ActionResult<ClientLoginResponse>> LoginClient(LoginDto request)
    {
        string email = request.Email;
        string password = request.Password;

        Console.WriteLine(JsonConvert.SerializeObject(request));

        ClientLoginResponse response = await _clientService.LoginAsync(email, password);
        if (response == null)
        {
            return BadRequest(new { errors = "Email ou mot de passe incorrect" });
        }

        return Ok(response);
    }

    [HttpGet("LLDreservations")]
    // [Authorize(Roles = "Client")]
    public async Task<ActionResult<IEnumerable<LongTermRental>>> GetClientLLDReservations()
    {
        int clientId = int.Parse(User.FindFirst("clientId")?.Value ?? "0");
        var LLDreservations = await _clientService.GetClientLLDReservations(clientId);

        return Ok(LLDreservations);
    }

    [HttpPost("change-password")]

    public async Task<ActionResult> ChangePassword(ChangePasswordDto request)
    {
        int clientId = int.Parse(User.FindFirst("clientId")?.Value ?? "0");

        try
        {
            await _clientService.ChangePasswordAsync(clientId, request);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(new { errors = ex.Message });
        }
    }
}