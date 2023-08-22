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
