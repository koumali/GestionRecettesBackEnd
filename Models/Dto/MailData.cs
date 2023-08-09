namespace AutomotiveApi.Models.Dto
{
    public class MailData
    {
        public string To { get; set; }      
        public string Subject { get; set; }
        public string? Body { get; set; } 
        public IFormFile?[] files { get; set; }
    }
}