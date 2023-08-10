using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    private readonly INotification _notification;

    public NotificationController(INotification notification)
    {
        _notification = notification;
    }

    [HttpGet("{agencyId}")]
    public async Task<ActionResult<IEnumerable<Notification>>> GetNotificationsForAgency(int agencyId)
    {
        var notifications = await _notification.GetNotifsForAgency(agencyId);
        return Ok(notifications);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Notification>> MarkNotificationAsRead(int id)
    {
        var notification = await _notification.MarkNotifAsRead(id);
        if (notification == null) return NotFound();
        return Ok(notification);
    }

    [HttpPost]
    public async Task<ActionResult<Notification>> CreateNotificationForAgency(int reservationId, string type)
    {
        var notification = await _notification.CreateNotifForAgency(reservationId, type);
        if (notification == null) return BadRequest();
        return Ok(notification);
    }
}