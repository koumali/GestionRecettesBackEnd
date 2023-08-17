using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
[Authorize(Roles = nameof(predefinedRoles.SuperAdmin))]
public class DashboardController : ControllerBase
{

    private readonly IDashboard _dashboardService;

    public DashboardController(IDashboard dashboardService)
    {
        _dashboardService = dashboardService;
    }


    [HttpGet("metrics")]
    public async Task<ActionResult<DashboardDto>> GetDashboard()
    {
        DashboardDto dashboard = await _dashboardService.GetDashboard();
        return Ok(dashboard);

    }


}