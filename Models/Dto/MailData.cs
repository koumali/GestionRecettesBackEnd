namespace AutomotiveApi.Models.Dto;

public class MailData
{
    public string To { get; set; }
    public string Subject { get; set; }
    public string? Body { get; set; }
    public string? url { get; set; }
    public IFormFile?[] files { get; set; }
}

public class MailAbonData : MailData
{
    public string? Nom { get; set; }
    public string? Tel { get; set; }
    public string? Adresse { get; set; }
}
public class MailLLDData : MailData
{
    public string? ClientNom { get; set; }
    public string? Modele { get; set; }
    public string? Duree { get; set; }
    public string? Montant { get; set; }
    public string? AgenceNom { get; set; }
    public string? AgenceTel { get; set; }
    public string? AgenceEmail { get; set; }

}public class MailReservData : MailData
{
    public string? ClientNom { get; set; }
    public string? Modele { get; set; }
    public DateTime? DateDebut { get; set; }
    public DateTime? DateFin { get; set; }
    public string? CodeReservation { get; set; }
    public string? AgenceNom { get; set; }
    public string? AgenceTel { get; set; }
    public string? AgenceEmail { get; set; }
    public string? MontantTotal { get; set; }

}
