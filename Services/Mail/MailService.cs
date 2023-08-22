using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using AutomotiveApi.Models.Dto;
using MimeKit.Text;
using Org.BouncyCastle.Asn1.Pkcs;

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

    public async Task SendAbonAsync(MailAbonData mailData)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("From").Value));
            email.To.Add(MailboxAddress.Parse(mailData.To));
            email.Subject = mailData.Subject;
            var multipart = new Multipart("mixed");

            var bodyBuilder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/EmailTemplate3.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("AGENCE NAME HERE", mailData.Nom);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Nom de l'Agence", mailData.Nom);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Adresse e-mail de l'Agence", mailData.To);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Numéro de téléphone de l'Agence", mailData.Tel);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Adresse de l'Agence", mailData.Adresse);
            }



            multipart.Add(new TextPart(TextFormat.Html)
            {
                Text = bodyBuilder.HtmlBody
            });


            email.Body = multipart;

            using var smtp = new SmtpClient();

            await smtp.ConnectAsync(_config.GetSection("Host").Value, int.Parse(_config.GetSection("Port").Value),
                SecureSocketOptions.StartTls);

            await smtp.AuthenticateAsync(_config.GetSection("Mail").Value, _config.GetSection("Password").Value);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        catch (Exception e)
        {
            throw new Exception("erreur lors de l'envoi du mail",e);
        }
    }

    public async Task SendAsync(MailData mailData)
    {
        try
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
        catch (Exception e)
        {
            throw new Exception("erreur lors de l'envoi du mail");
        }
    }

    public async Task SendReservAsync(MailReservData mailData)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("From").Value));
            email.To.Add(MailboxAddress.Parse(mailData.To));
            email.Subject = mailData.Subject;
            var multipart = new Multipart("mixed");

            var bodyBuilder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/EmailTemplate2.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CLIENT NAME HERE", mailData.ClientNom);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Nom et description du modèle", mailData.Modele);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("DATE DEBUT1 HERE", mailData.DateDebut.ToString());
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("DATE DEBUT2 HERE", mailData.DateDebut.ToString());
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("DATE FIN HERE", mailData.DateFin.ToString());
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CODE HERE", mailData.CodeReservation);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Numéro de téléphone de l'Agence", mailData.AgenceTel);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Adresse e-mail de l'Agence", mailData.AgenceEmail);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Montant totale", mailData.MontantTotal);
            }



            multipart.Add(new TextPart(TextFormat.Html)
            {
                Text = bodyBuilder.HtmlBody
            });


            email.Body = multipart;

            using var smtp = new SmtpClient();

            await smtp.ConnectAsync(_config.GetSection("Host").Value, int.Parse(_config.GetSection("Port").Value),
                SecureSocketOptions.StartTls);

            await smtp.AuthenticateAsync(_config.GetSection("Mail").Value, _config.GetSection("Password").Value);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        catch (Exception e)
        {
            throw new Exception("erreur lors de l'envoi du mail", e);
        }
    }
}