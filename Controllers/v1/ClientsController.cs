using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClient _clientService;


        public ClientsController(IClient clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            var clients = await _clientService.GetAllAsync();
            return Ok(clients);
        }

        // get clients of a specific agence
        [HttpGet("{idAgence}")]
        [Authorize(Roles = "Commercial, Gerant")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClientsAgence(int idAgence)
        {
            var clients = await _clientService.GetClientsAgence(idAgence);
            return Ok(clients);
        }

        //<summary>
        //Add Client
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<Client>> AddClient(ClientDto request)
        {
            var client = _mapper.Map<Client>(request);

            var addedClient = await _clientService.CreateAsync(client);
            return Ok(addedClient);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin, Gerant, Commercial")]
        public async Task<ActionResult<Client>> GetClientById(int id)
        {
            var client = await _clientService.GetByIdAsync(id);
            return Ok(client);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin, Gerant, Commercial")]
        public async Task<ActionResult> DeleteClient(int id)
        {
            await _clientService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin, Gerant, Commercial")]
        public async Task<ActionResult<Client>> UpdateClient(int id, ClientDto request)
        {
            var client = await _clientService.GetByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            client.FirstName = request.FirstName;
            client.LastName = request.LastName;
            client.Tel = request.Tel;
            client.Email = request.Email;
            client.Ville = request.Ville;
            client.ZipCode = request.ZipCode;
            client.Adresse = request.Adresse;
            client.Adresse2 = request.Adresse2;
            client.PermisRecto = request.PermisRecto;
            client.PermisVerso = request.PermisVerso;
            var updatedClient = await _clientService.UpdateAsync(client);
            return Ok(updatedClient);
        }
    }
}