using System.Security.Claims;
using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using AutomotiveApi.Utility.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClient _clientService;
        private readonly IFileHelper _fileHelper;


        public ClientsController(IClient clientService, IMapper mapper, IFileHelper fileHelper, IJwt jwtService)
        {
            _clientService = clientService;
            _mapper = mapper;
            _fileHelper = fileHelper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            var clients = await _clientService.GetAllAsync();
            return Ok(clients);
        }

        // get clients of a specific agence
        [HttpGet("agence/{idAgence}")]
        [Authorize(Roles = "Commercial, Gerant")]
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClientsAgence(int idAgence)
        {
            var clients = await _clientService.GetClientsAgence(idAgence);
            return Ok(clients);
        }

        //<summary>
        //Add Client
        //</summary>

        [HttpPost]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
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
        [Authorize(Roles = "Admin, Gerant, Commercial")]
        public async Task<ActionResult<Client>> GetClientById(int id)
        {
            var client = await _clientService.GetByIdAsync(id);
            return Ok(client);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Gerant, Commercial")]
        public async Task<ActionResult> DeleteClient(int id)
        {
            await _clientService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Gerant, Commercial,Client")]
        public async Task<ActionResult<Client>> UpdateClient(int id, [FromForm] ClientDto request)
        {

            if (id != request.Id)
            {
                return BadRequest(new { errors = "Invalid Client" });
            }
            Client? client = await _clientService.UpdateAsync(request);

            return Ok(client);


        }


        [HttpGet("infos")]
        [Authorize(Roles = "Client")]
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
                return BadRequest(new { errors = "You must accept terms and conditions" });
            }
            try
            {
                return await _clientService.RegisterAsync(request);
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
        [Authorize(Roles = "Client")]
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
                return BadRequest(new { errors = "Invalid Credentials" });
            }

            return Ok(response);


        }

    }
}