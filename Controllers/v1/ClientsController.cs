using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IJwt _jwtService;
        private readonly IMapper _mapper;
        private readonly IClient _clientService;


        public ClientsController(IUser userService, IJwt jwtService, IClient ClientService, IMapper mapper)
        {
            _jwtService = jwtService;
            _clientService = ClientService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            var clients = await _clientService.GetAllAsync();
            return Ok(clients);
        }
        //<summary>
        //Add Client
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Client>> AddClient(ClientDto request)
        {
            // var client = new Client()
            // {
            // };
            // client.first_name = request.first_name;
            // client.last_name = request.last_name;
            // client.tel = request.tel;
            // client.email = request.email;
            // client.ville = request.ville;
            // client.zipcode = request.zipcode;
            // client.adresse = request.adresse;
            // client.adresse2 = request.adresse2;
            // client.permis_recto = request.permis_recto;
            // client.permis_verso = request.permis_verso;
            var client = _mapper.Map<Client>(request);

            var addedClient = await _clientService.CreateAsync(client);
            return Ok(addedClient);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Client>> GetClientById(int id)
        {
            var client = await _clientService.GetByIdAsync(id);
            return Ok(client);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteClient(int id)
        {
            await _clientService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Client>> UpdateClient(int id, ClientDto request)
        {
            var result = await _clientService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            // Update the Client properties
            // client.first_name = request.first_name;
            // client.last_name = request.last_name;
            // client.tel = request.tel;
            // client.email = request.email;
            // client.ville = request.ville;
            // client.zipcode = request.zipcode;
            // client.adresse = request.adresse;
            // client.adresse2 = request.adresse2;
            // client.permis_recto = request.permis_recto;
            // client.permis_verso = request.permis_verso;
            var client = _mapper.Map<Client>(request);

            var updatedClient = await _clientService.UpdateAsync(client);
            return Ok(updatedClient);
        }
    }
}