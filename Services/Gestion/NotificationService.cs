using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

public class NotificationService : GenericDataService<Notification>, INotification
{
    private readonly AppDbContext _context;

    public NotificationService(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Notification> CreateNotifForAgency(int itemId, string type)
    {
        var notification = new Notification
        {
            Message = "",
            CreatedAt = DateTime.UtcNow,
            IsRead = false,
        };

        if (type == "Reservation")
        {
            var reservation = await _context.Reservations.FindAsync(itemId);
            if (reservation == null) return null;
            notification.ReservationId = itemId;
            notification.Message = "Nouvelle Reservation";
        }

        else if (type == "LongTermRental")
        {
            var reservation = await _context.long_term_rentals.FindAsync(itemId);
            if (reservation == null) return null;
            notification.LLDReservationId = itemId;
            notification.Message = "Nouvelle Reservation Long Terme";
        }
        else
        {
            return null;
        }

        await _context.Notifications.AddAsync(notification);
        await _context.SaveChangesAsync();

        return notification;
    }

    public async Task<IEnumerable<Notification>> GetNotifsForAgency(int agencyId)
    {
        var notifsREservation = await _context.Notifications
            .Where(n => n.LongTermRentals.idAgence == agencyId)
            .ToListAsync();
        var notifsLLD = await _context.Notifications
            .Where(n => n.Reservation.Vehicule.IdAgence == agencyId)
            .ToListAsync();
        var notifs = notifsREservation.Concat(notifsLLD).ToList();
        return notifs;
    }

    public async Task<Notification?> MarkNotifAsRead(int notificationId)
    {
        var notification = await _context.Notifications.FindAsync(notificationId);
        if (notification != null)
        {
            notification.IsRead = true;
            notification.UpdatedAt = DateTime.UtcNow;
            _context.Notifications.Update(notification);
            _context.SaveChanges();
        }

        return notification;
    }
}