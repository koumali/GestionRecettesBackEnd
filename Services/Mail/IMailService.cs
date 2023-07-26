using AutomotiveApi.Models.Dto;

namespace AutomotiveApi.Services.Mail;

public interface IMailService
{
    void SendEmail(AgenceClientDto mailRequest);
    bool SendFullEmail(MailData mailData);
}