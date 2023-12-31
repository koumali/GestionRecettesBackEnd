﻿using MailKit.Net.Smtp;
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

    public async Task SendAbonAsync(MailAbonData mailData)
    {
        try
        {

            var bodyBuilder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/EmailTemplate3.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("AGENCE_NAME_HERE", mailData.Nom);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("AGC_NAME_HERE", mailData.Nom);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("EMAIL_HERE", mailData.To);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("NUMERO_HERE", mailData.Tel);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("ADDRESS_HERE", mailData.Adresse);
            }


            await BaseSendEmailAsync(bodyBuilder, mailData);
        }
        catch (Exception e)
        {
            throw new Exception("erreur lors de l'envoi du mail", e);
        }
    }

    public async Task SendAsync(MailData mailData)
    {
        try
        {
            var bodyBuilder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/EmailPass.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CONTENT_HERE", mailData.Body);
                if (mailData.url != null)
                {
                    bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("URL_HERE", mailData.url);

                    if (mailData.Body.Contains("mot de passe"))
                    {
                        bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("BUTTON_HERE", "Changer le mot de passe");
                    }
                    else
                    {
                        bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("BUTTON_HERE", "Vérifier l'email");
                    }
                }
            }

            await BaseSendEmailAsync(bodyBuilder, mailData);
        }
        catch (Exception e)
        {
            throw new Exception("erreur lors de l'envoi du mail");
        }
    }


    public async Task SendLLDResponseAsync(MailLLDResponseData mailData)
    {
        try
        {
            var bodyBuilder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/LLDResponse.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CONTENT_HERE", mailData.Body);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("PRICE_HERE", mailData.prix);
            }

            await BaseSendEmailAsync(bodyBuilder, mailData);
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

            var bodyBuilder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/EmailTemplate2.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CLIENT_NAME_HERE", mailData.ClientNom);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("MODELE_HERE", mailData.Modele);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("DATE_DEBUT1_HERE", mailData.DateDebut.ToString());
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("DATE_DEBUT2_HERE", mailData.DateDebut.ToString());
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("DATE_FIN_HERE", mailData.DateFin.ToString());
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CODE_HERE", mailData.CodeReservation);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("NUMERO_HERE", mailData.AgenceTel);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("EMAIL_AGENCE_HERE", mailData.AgenceEmail);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("Montant_HERE", mailData.MontantTotal);
            }

            await BaseSendEmailAsync(bodyBuilder, mailData);

        }
        catch (Exception e)
        {
            throw new Exception("erreur lors de l'envoi du mail", e);
        }
    }


    public async Task SendLLDAsync(MailLLDData mailData)
    {
        try
        {

            var bodyBuilder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(_hostingEnvironment.WebRootPath + "/Templates/LLDDemande.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();

                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CLIENT_NAME_HERE", mailData.ClientNom);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("MODELE_HERE", mailData.Modele);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("DUREE_HERE", mailData.Duree);
                bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("CODE_HERE", mailData.NumeroReservation);
            }

            await BaseSendEmailAsync(bodyBuilder, mailData);

        }
        catch (Exception e)
        {
            throw new Exception("erreur lors de l'envoi du mail", e);
        }
    }


    private async Task BaseSendEmailAsync(BodyBuilder bodyBuilder, MailData mailData)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("From").Value));
            email.To.Add(MailboxAddress.Parse(mailData.To));
            email.Subject = mailData.Subject;
            var multipart = new Multipart("mixed");

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
            throw new Exception("erreur lors de l'envoi du mail", e);
        }
    }
}