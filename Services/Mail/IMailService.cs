using AutomotiveApi.Models.Dto;

namespace AutomotiveApi.Services.Mail;

public interface IMailService
{
    Task SendAsync(MailData mailRequest);
    Task SendAbonAsync(MailAbonData mailRequest);
    
}