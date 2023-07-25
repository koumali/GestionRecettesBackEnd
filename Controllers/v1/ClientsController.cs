using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
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
        private readonly IFileHelper _fileHelper;


        public ClientsController(IClient clientService, IMapper mapper, IFileHelper fileHelper)
        {
            _clientService = clientService;
            _mapper = mapper;
            _fileHelper = fileHelper;
        }

        // [HttpGet]
        // // [Authorize(Roles = "Admin")]
        // public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        // {
        //     var clients = await _clientService.GetAllAsync();
        //     return Ok(clients);
        // }

        // get clients of a specific agence
        [HttpGet("agence/{idAgence}")]
        [HasPermission(Permission.AgencySecondLevelPermission)]
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
        [HasPermission(Permission.AgencySecondLevelPermission)]
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
        // [Authorize(Roles = "Admin, Gerant, Commercial")]
        public async Task<ActionResult<Client>> GetClientById(int id)
        {
            var client = await _clientService.GetByIdAsync(id);
            return Ok(client);
        }

        [HttpDelete("{id}")]
        [HasPermission(Permission.AgencySecondLevelPermission)]
        public async Task<ActionResult> DeleteClient(int id)
        {
            await _clientService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [HasPermission(Permission.AgencySecondLevelPermission)]
        public async Task<ActionResult<Client>> UpdateClient(int id, [FromForm] ClientDto request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            var client = await _clientService.GetByIdAsync(id);

            if (request.PermisRecto != null)
            {
                client.PermisRecto = await _fileHelper.UploadImage(request.PermisRecto, "Permis");
            }
            if (request.PermisVerso != null)
            {
                client.PermisVerso = await _fileHelper.UploadImage(request.PermisVerso, "Permis");
            }

            client.FirstName = request.FirstName;
            client.LastName = request.LastName;
            client.Tel = request.Tel;
            client.Email = request.Email;
            client.Ville = request.Ville;
            client.ZipCode = request.ZipCode;
            client.Adresse = request.Adresse;
            client.Adresse2 = request.Adresse2;

            var updatedClient = await _clientService.UpdateAsync(client);
            return Ok(updatedClient);
        }
    }
}