using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion;
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
        private readonly IClient _ClientService;


        public ClientsController(IUser userService, IJwt jwtService, IClient ClientService)
        {
            _jwtService = jwtService;
            _ClientService = ClientService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Client>> GetClients()
        {
            var Clients = _ClientService.getClients();
            return Ok(Clients);
        }
        //<summary>
        //Add Client
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Client> AddClient(ClientDto request)
        {
            var client = new Client()
            {
            };
            client.first_name = request.first_name;
            client.last_name = request.last_name;
            client.tel = request.tel;
            client.email = request.email;
            client.ville = request.ville;
            client.zipcode = request.zipcode;
            client.adresse = request.adresse;
            client.adresse2 = request.adresse2;
            client.permis_recto = request.permis_recto;
            client.permis_verso = request.permis_verso;

            var addedClient = _ClientService.add(client);
            return Ok(addedClient);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Client> GetClientById(int id)
        {
            var Client = _ClientService.findById(id);
            return Ok(Client);
        }
        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteClient(int id)
        {
            _ClientService.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Client> UpdateClient(int id, ClientDto request)
        {
            var client = _ClientService.findById(id);
            if (client == null)
            {
                return NotFound();
            }

            // Update the Client properties
            client.first_name = request.first_name;
            client.last_name = request.last_name;
            client.tel = request.tel;
            client.email = request.email;
            client.ville = request.ville;
            client.zipcode = request.zipcode;
            client.adresse = request.adresse;
            client.adresse2 = request.adresse2;
            client.permis_recto = request.permis_recto;
            client.permis_verso = request.permis_verso;

            var updatedClient = _ClientService.update(client);
            return Ok(updatedClient);
        }
    }

}