using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param
{
    public class DashboardService : IDashboard
    {
        private readonly AppDbContext _context;

        public DashboardService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<DashboardDto> GetDashboard()
        {
            DashboardDto dashboard = new DashboardDto();
            dashboard.Clients = await _context.Clients.CountAsync();
            dashboard.Users = await _context.Users.CountAsync();
            dashboard.Vehicules = await _context.Vehicules.CountAsync();
            dashboard.Reservations = await _context.Reservations.CountAsync();
            dashboard.AgencesVerified = await _context.Agences.Where(a => a.IsVerified == true).CountAsync();
            dashboard.AgencesNotVerified = await _context.Agences.Where(a => a.IsVerified == false).CountAsync();            
            dashboard.Offres = await _context.Offres.CountAsync();
            dashboard.Lld = await _context.long_term_rentals.Where(l => l.idAgence != null).CountAsync();
            return dashboard;
        }
    }

}