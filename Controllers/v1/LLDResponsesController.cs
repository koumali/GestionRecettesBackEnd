﻿using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using Microsoft.AspNetCore.Mvc;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
using AutomotiveApi.Services.Mail;

namespace AutomotiveApi.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
public class LLDResponsesController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ILLDResponse _LLDResponseService;
    private readonly IMailService _mailService;


    public LLDResponsesController(ILLDResponse LLDResponseService, IMapper mapper, IMailService mailService)
    {
        _mailService = mailService;
        _LLDResponseService = LLDResponseService;
        _mapper = mapper;
    }

    [HttpGet]
    [HasPermission(PredefinedPermissions.LongTerm)]
    public async Task<ActionResult<IEnumerable<LLDResponse>>> GetLLDResponses()
    {
        var LLDResponses = await _LLDResponseService.GetAllAsync();
        return Ok(LLDResponses);
    }


    [HttpGet("{id}")]
    [HasPermission(PredefinedPermissions.LongTerm)]
    public async Task<ActionResult<LLDResponse>> GetLLDResponseById(int id)
    {
        var LLDResponse = await _LLDResponseService.GetByIdAsync(id);
        return Ok(LLDResponse);
    }

    [HttpPost]
    [HasPermission(PredefinedPermissions.LongTerm)]
    public async Task<ActionResult<LLDResponse>> AddLLDResponse([FromForm] LLDResponseDto request)
    {
        var LLDResponse = _mapper.Map<LLDResponse>(request);

        var addedLLDResponse = await _LLDResponseService.CreateAsync(LLDResponse);

        try
        {
            string? email = await _LLDResponseService.GetEmailByIdAsync(addedLLDResponse.idLongTermRental);

            MailData mailData = new MailData
            {
                To = email,
                Subject = request.title,
                Body = request.description + "\n Prix : " + request.prix,
                files = request.files
            };


            await _mailService.SendAsync(mailData);

            return Ok(addedLLDResponse);
        }
        catch (Exception e)
        {
            return BadRequest(new { errors = "une erreur est survenue lors de l'envoi de l'email" });
        }
    }

    [HttpDelete("{id}")]
    [HasPermission(PredefinedPermissions.LongTerm)]
    public async Task<ActionResult> DeleteLLDResponse(int id)
    {
        await _LLDResponseService.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("{id}")]
    [HasPermission(PredefinedPermissions.LongTerm)]
    public async Task<ActionResult<LLDResponse>> UpdateLLDResponse(int id, [FromForm] LLDResponseDto request)
    {
        if (id != request.idLongTermRental)
        {
            return BadRequest(new { errors = "id non valide" });
        }

        var LLDResponse = await _LLDResponseService.GetByIdAsync(id);

        LLDResponse.prix = request.prix;
        LLDResponse.description = request.description;

        var updatedLLDResponse = await _LLDResponseService.UpdateAsync(LLDResponse);
        return Ok(updatedLLDResponse);
    }
}