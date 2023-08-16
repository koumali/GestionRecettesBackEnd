using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using AutomotiveApi.Models.Dto;
using MimeKit.Text;

namespace AutomotiveApi.Services.Mail;

public class MailService : IMailService
{
    private readonly IConfiguration _config;
    private readonly IWebHostEnvironment _hostingEnvironment;


    public MailService(IConfiguration config, IWebHostEnvironment hostingEnvironment)
    {
        _config = config;
        _hostingEnvironment = hostingEnvironment;
    }


    public async Task SendAsync(MailData mailData)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config.GetSection("From").Value));
        email.To.Add(MailboxAddress.Parse(mailData.To));
        email.Subject = mailData.Subject;
        var multipart = new Multipart("mixed");

        var bodyBuilder = new BodyBuilder();

        using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/EmailTemplate.html"))
        {
            bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

            bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CONTENT HERE", mailData.Body);
            bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("URL HERE", mailData.url);
        }



        multipart.Add(new TextPart(TextFormat.Html)
        {
            Text = bodyBuilder.HtmlBody

        });


        if (mailData.files != null)
        {
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