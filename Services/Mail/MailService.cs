using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using AutomotiveApi.Models.Dto;
using MimeKit.Text;

namespace AutomotiveApi.Services.Mail;

public class MailService : IMailService
{
    private readonly IConfiguration _config;

    public MailService(IConfiguration config)
    {
        _config = config;
    }


    public async Task SendAsync(MailData mailData)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config.GetSection("From").Value));
        email.To.Add(MailboxAddress.Parse(mailData.To));
        var multipart = new Multipart("mixed");
        multipart.Add(new TextPart(TextFormat.Html) { Text = mailData.Body });


        foreach (var file in mailData.files)
        {

            var content = new MemoryStream();
            file.CopyTo(content);
            content.Position = 0;

            var contentType = ContentType.Parse(file.ContentType);
            var part = new MimePart(contentType.MimeType)
            {
                FileName = Path.GetFileName(file.FileName),
                ContentTransferEncoding = ContentEncoding.Base64,
                Content = new MimeContent(content),
            };

            multipart.Add(part);
        }

        email.Body = multipart;

        using var smtp = new SmtpClient();

        await smtp.ConnectAsync(_config.GetSection("Host").Value, int.Parse(_config.GetSection("Port").Value),
                    SecureSocketOptions.StartTls);

        await smtp.AuthenticateAsync(_config.GetSection("Mail").Value, _config.GetSection("Password").Value);
        await smtp.SendAsync(email);
        await smtp.DisconnectAsync(true);
    }
}