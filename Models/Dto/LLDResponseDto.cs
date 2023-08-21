namespace AutomotiveApi.Models.Dto;

public class LLDResponseDto
{
    public int prix { get; set; }

    public string? title { get; set; }
    public string description { get; set; }
    public int idAgence { get; set; }
    public int idLongTermRental { get; set; }
    public bool isAgence { get; set; }
    public IFormFile?[] files { get; set; }
}