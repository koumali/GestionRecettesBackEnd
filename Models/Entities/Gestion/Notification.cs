using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public class Notification: ModelBase
    {
        public Notification() { }
        public int? ReservationId { get; set; }
        public int? LLDReservationId { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }

        public virtual Reservation? Reservation { get; set; }
        public virtual LongTermRental? LongTermRentals { get; set; }
    }
}
