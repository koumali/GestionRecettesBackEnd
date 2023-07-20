namespace AutomotiveApi.Utility;

public static class ReservationNumberGenerator
{
    private static readonly HashSet<string> GeneratedNumbers = new HashSet<string>();

    public static string GenerateReservationNumber()
    {
        string reservationNumber;

        do
        {
            var guid = Guid.NewGuid();
            var hashCode = guid.GetHashCode();
            hashCode = Math.Abs(hashCode);
            var firstPart = hashCode % 99 + 1;
            var secondPart = guid.ToString("N")[..8];
            reservationNumber = $"{firstPart:D2}-{secondPart[..4]}-{secondPart[4..]}";
        } while (GeneratedNumbers.Contains(reservationNumber));

        GeneratedNumbers.Add(reservationNumber);

        return reservationNumber;
    }
}