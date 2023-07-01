using automotiveApi.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.DependencyInjection.Extensions;
using automotiveApi.Services.Jwt;
using automotiveApi.Services.Param;
using automotiveApi.Services.Auth;
using Microsoft.OpenApi.Models;
using automotiveApi.Services.Gestion;
using automotiveApi.Utility;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
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
builder.Services.AddScoped<IJwt, JwtService>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IAuth, AuthService>();
builder.Services.AddScoped<IRole, RoleService>();
builder.Services.AddScoped<IAgence, AgenceService>();
builder.Services.AddScoped<IMarque, MarqueService>();
builder.Services.AddScoped<IModele, ModeleService>();
builder.Services.AddScoped<IClient, ClientService>();
builder.Services.AddScoped<IVehicule, VehiculeService>();
builder.Services.AddScoped<IOffre, OffreService>();
builder.Services.AddScoped<IReservation, ReservationService>();

var mappingConfig = new MapperConfiguration(mc =>
          {
              mc.AddProfile(new MapperConfig());
          });

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddDbContext<AppDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnectionMySql")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors();


app.UseWhen(context => context.Request.Path.StartsWithSegments("/api"), appBuilder =>
{
    appBuilder.UseMiddleware<ApiKeyChecker>();
});



app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
