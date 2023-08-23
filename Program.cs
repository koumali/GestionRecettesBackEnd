using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Auth;
using AutomotiveApi.Services.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Mail;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using AutomotiveApi.Utility.Middlwares;
using Microsoft.AspNetCore.Authorization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1"
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert JWT with Bearer into field",
        Name = "Authorization Bearer",
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ClockSkew = TimeSpan.Zero,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
            ),
        };
    });

// add identity
builder.Services.AddHttpClient();


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", p => p.RequireRole(predefinedRoles.SuperAdmin.ToString()));
});


builder.Services.AddAuthorization();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IJwt, JwtService>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IAuth, AuthService>();
builder.Services.AddScoped<IRole, RoleService>();
builder.Services.AddScoped<IAgence, AgenceService>();
builder.Services.AddScoped<IModele, ModeleService>();
builder.Services.AddScoped<IMarque, MarqueService>();
builder.Services.AddScoped<IClient, ClientService>();
builder.Services.AddScoped<IVehicule, VehiculeService>();
builder.Services.AddScoped<IOffre, OffreService>();
builder.Services.AddScoped<IReservation, ReservationService>();
builder.Services.AddScoped<ILogJournal, LogJournalService>();
builder.Services.AddScoped<IContrat, ContratService>();
builder.Services.AddScoped<ILongTermRental, LongTermRentalService>();
builder.Services.AddScoped<ILLDResponse, LLDResponsesService>();
builder.Services.AddScoped<IFileHelper, FileHelper>();
builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddScoped<INotification, NotificationService>();
builder.Services.AddScoped<IPasswordReset, PasswordResetService>();
builder.Services.AddScoped<IEmailVerification, EmailVerificationService>();
builder.Services.AddScoped<IDashboard, DashboardService>();

builder.Services.AddTransient<IAuthorizationHandler, PermissionAuthorizationHandler>();
builder.Services.AddTransient<IPermissionService, PermissionService>();
builder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionAuthorizationPolicyProvider>();


var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MapperConfig()); });


builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnectionMySql")));



var app = builder.Build();

// Configure the HTTP request pipeline.



app.UseMiddleware<ErrorHandlingMiddleware>();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();

app.UseHttpsRedirection();





app.UseWhen(context => context.Request.Path.StartsWithSegments("/api"), appBuilder => { appBuilder.UseMiddleware<ApiKeyChecker>(); });







app.UseAuthentication();
app.UseAuthorization();



app.UseMiddleware<FileAccessMiddlware>();

app.UseStaticFiles();




app.MapControllers();




app.Run();