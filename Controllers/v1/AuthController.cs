using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Auth;
using AutomotiveApi.Services.Mail;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuth _authService;
    protected readonly IMapper _mapper;
    private readonly IPasswordReset _passwordResetService;
    private readonly IMailService _mailService;
    private readonly IEmailVerification _emailVerificationService;


    public AuthController(AppDbContext context, IAuth authService, IMapper mapper,
     IPasswordReset passwordResetService, IMailService mailService, IEmailVerification emailVerificationService)
    {
        _authService = authService;
        _mapper = mapper;
        _passwordResetService = passwordResetService;
        _mailService = mailService;
        _emailVerificationService = emailVerificationService;
    }



    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(UserDto request)
    {
        var user = _mapper.Map<User>(request);

        try
        {
            var newUser = await _authService.register(user);
            return Ok(newUser);
        }
        catch (Exception ex)
        {
            return BadRequest(new { errors = ex.Message });
        }
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResponse>> Login(LoginDto request)
    {
        try
        {
            var email = request.Email;
            var password = request.Password;
            var loginResponse = await _authService.login(email, password);
            return Ok(loginResponse);
        }
        catch (Exception ex)
        {
            return BadRequest(new { errors = ex.Message });
        }
    }

    [HttpPost("forgot-password")]
    public async Task<ActionResult> SendResetPassword(PasswordRestTokenRequest request)
    {
        try
        {
            string token = await _passwordResetService.GeneratePasswordResetToken(request.Email);
            string url = $"{Request.Scheme}://{Request.Host}/reset-password?token={token}";
            MailData mailData = new MailData
            {
                To = request.Email,
                Subject = "Reinitialisation de mot de passe",
                Body = "Veuillez cliquer sur le lien ci-dessous pour réinitialiser votre mot de passe",
                url = url                
            };

            await _mailService.SendAsync(mailData);

            return Ok(new { message = "Reset password link sent successfully" });
        }
        catch (Exception ex)
        {
            // add message to errors list
            return BadRequest(new { errors = ex.Message });
        }
    }

    [HttpPost("reset-password")]
    public async Task<ActionResult> ResetPassword(PasswordResetDto request)
    {
        try
        {
            var isChanged = await _passwordResetService.ResetPassword(request);
            if (isChanged)
            {
                return Ok(new { message = "Votre mot de passe a été changé avec succès" });
            }

            return BadRequest(new { message = "Votre mot de passe n'a pas été changé" });
        }
        catch (Exception ex)
        {
            // add message to errors list
            return BadRequest(new { errors = ex.Message });
        }

    }

    [HttpPost("send-verification")] 
    [Authorize]

    public async Task<ActionResult> SendEmailVerification([FromForm] string email)
    {
        try
        {
            string token = await _emailVerificationService.GenerateVerificationToken(email);
            string url = $"{Request.Scheme}://{Request.Host}/verify-email?token={token}";
            MailData mailData = new MailData
            {
                To = email,
                Subject = "Verification de l'email",
                Body = "Veuillez cliquer sur le lien ci-dessous pour vérifier votre email",
                url = url
            };

            await _mailService.SendAsync(mailData);

            return Ok(new { message = "email de vérification a été envoyé avec succès" });
        }
        catch (Exception ex)
        {
            // add message to errors list
            return BadRequest(new { errors = ex.Message });
        }
    }


    [HttpGet("verify-email")]
    public async Task<ActionResult> VerifyEmail([FromQuery] string token)
    {
        try
        {
            var isVerified = await _emailVerificationService.VerifyEmail(token);
            if (isVerified)
            {
                return Ok(new { message = "vous avez vérifié votre email avec succès" });
            }

            return BadRequest(new { message = "votre email n'a pas été vérifié" });
        }
        catch (Exception ex)
        {
            // add message to errors list
            return BadRequest(new { errors = ex.Message });
        }
    }
}