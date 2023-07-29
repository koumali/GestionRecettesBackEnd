using AutomotiveApi.Models.Entities.Gestion;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Services.Gestion.Interfaces
{
    public interface INotification : IGenericData<Notification>
    {
        Task<Notification> MarkNotifAsRead(int notificationId);
        Task<IEnumerable<Notification>> GetNotifsForAgency(int agencyId);
        Task<Notification?> CreateNotifForAgency(int reservationId,string type);
    }
}