using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [HasPermission(Permission.PlatformTopLevelPermission)]
    public class LongTermRentalsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILongTermRental _longTermRentalService;


        public LongTermRentalsController(ILongTermRental longTermRentalService, IMapper mapper)
        {
            _longTermRentalService = longTermRentalService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LongTermRental>>> GetLongTermRentals()
        {
            var longTermRentals = await _longTermRentalService.GetAllAsync();
            return Ok(longTermRentals);
        }
       

        [HttpGet("{id}")]
        public async Task<ActionResult<LongTermRental>> GetLongTermRentalById(int id)
        {
            var longTermRental = await _longTermRentalService.GetByIdAsync(id);
            return Ok(longTermRental);
        }

        [HttpPost]
        public async Task<ActionResult<LongTermRental>> AddLongTermRental(LongTermRentalDto request)
        {
            var longTermRental = _mapper.Map<LongTermRental>(request);
            var addedLongTermRental = await _longTermRentalService.CreateAsync(longTermRental);
            return Ok(addedLongTermRental);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteLongTermRental(int id)
        {
            await _longTermRentalService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LongTermRental>> UpdateLongTermRental(int id, LongTermRentalDto request)
        {
            var longTermRental = await _longTermRentalService.GetByIdAsync(id);
            if (longTermRental == null)
            {
                return NotFound();
            }

            // Update the LongTermRental properties
            longTermRental.prenom = request.prenom;
            longTermRental.nom = request.nom;
            longTermRental.phone = request.phone;
            longTermRental.zip = request.zip;
            longTermRental.email = request.email;
            longTermRental.type_vehicule = request.type_vehicule;
            longTermRental.duree = request.duree;
            longTermRental.entreprise = request.entreprise;
            longTermRental.ville = request.ville;
            longTermRental.description = request.description;

            var updatedLongTermRental = await _longTermRentalService.UpdateAsync(longTermRental);
            return Ok(updatedLongTermRental);
        }
    }
}