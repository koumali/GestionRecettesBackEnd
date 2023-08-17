using AutomotiveApi.Models.Dto;

namespace AutomotiveApi.Services.Param
{
    public interface IDashboard
    {
        Task<DashboardDto> GetDashboard();
        
    }
}