using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Services.Auth;
using AutomotiveApi.Services.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using AutomotiveApi.Utility.Middlwares;


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
    options.AddPolicy("RequireAdminRole", p => p.RequireRole("Admin"));
    options.AddPolicy("RequireUserRole", p => p.RequireRole("Client"));
    options.AddPolicy("RequireUserRole", p => p.RequireRole("Gearnt"));
    options.AddPolicy("RequireUserRole", p => p.RequireRole("Agent"));
});


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
builder.Services.AddTransient<IJwt, JwtService>();
builder.Services.AddTransient<IUser, UserService>();
builder.Services.AddTransient<IAuth, AuthService>();
builder.Services.AddTransient<IRole, RoleService>();
builder.Services.AddTransient<IAgence, AgenceService>();
builder.Services.AddTransient<IMarque, MarqueService>();
builder.Services.AddTransient<IModele, ModeleService>();
builder.Services.AddTransient<IClient, ClientService>();
builder.Services.AddTransient<IVehicule, VehiculeService>();
builder.Services.AddTransient<IOffre, OffreService>();
builder.Services.AddTransient<IReservation, ReservationService>();
builder.Services.AddTransient<ILogJournal, LogJournalService>();
builder.Services.AddTransient<IContrat, ContratService>();

var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MapperConfig()); });


builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnectionMySql")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors();


app.UseWhen(context => context.Request.Path.StartsWithSegments("/api"),
    appBuilder => { appBuilder.UseMiddleware<ApiKeyChecker>(); });


app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();