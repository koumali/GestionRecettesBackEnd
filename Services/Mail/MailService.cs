using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using AutomotiveApi.Models.Dto;

namespace AutomotiveApi.Services.Mail;

public class MailService : IMailService
{
    private readonly IConfiguration _config;

    public MailService(IConfiguration config)
    {
        _config = config;
    }

    public void SendEmail(AgenceClientDto mailRequest)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config.GetSection("Mail").Value));
        email.To.Add(MailboxAddress.Parse(_config.GetSection("Mail").Value));
        email.Subject = mailRequest.Name;
        email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = $"message = {mailRequest.Address}, email = {mailRequest.Email}, phone = {mailRequest.Tel} "
        };

        using var smtp = new SmtpClient();
        smtp.Connect(_config.GetSection("Host").Value, int.Parse(_config.GetSection("Port").Value),
            SecureSocketOptions.StartTls);
        smtp.Authenticate(_config.GetSection("Mail").Value, _config.GetSection("Password").Value);
        smtp.Send(email);
        smtp.Disconnect(true);
    }

    public bool SendFullEmail(MailData mailData)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config.GetSection("Mail").Value));
        email.To.Add(MailboxAddress.Parse(mailData.To));
        email.Subject = mailData.Subject;
        email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = mailData.Body
        };

        using var smtp = new SmtpClient();
        smtp.Connect(_config.GetSection("Host").Value, int.Parse(_config.GetSection("Port").Value),
            SecureSocketOptions.StartTls);
        smtp.Authenticate(_config.GetSection("Mail").Value, _config.GetSection("Password").Value);
        smtp.Send(email);
        smtp.Disconnect(true);
        return true;
    }
}