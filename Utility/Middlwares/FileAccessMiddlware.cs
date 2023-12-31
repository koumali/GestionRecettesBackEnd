using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Utility.Middlwares;

public class FileAccessMiddlware
{
    private readonly RequestDelegate _next;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public FileAccessMiddlware(RequestDelegate next, IWebHostEnvironment hostingEnvironment)
    {
        _next = next;
        _hostingEnvironment = hostingEnvironment;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var path = context.Request.Path.Value;
    
        if (path.StartsWith("/Permis"))
        {
    
            // split path to get folder name
            var folderName = path.Split("/")[2];

            try
            {
                int folderId = Int32.Parse(folderName);
                int clientId = int.Parse(context.User.FindFirst("clientId")?.Value ?? "0");

           

                int idAgence = string.IsNullOrEmpty(context.User.FindFirst("idAgence")?.Value)
                    ? 0
                    : int.Parse(context.User.FindFirst("idAgence")?.Value);


                AppDbContext? _context = context.RequestServices.GetService(typeof(AppDbContext)) as AppDbContext;


                bool hasAccess = await _context.Set<Contrat>()
                    .Where(c => c.IdClient == folderId && c.Reservation.Vehicule.IdAgence == idAgence).AnyAsync();

            

                if (clientId == folderId || hasAccess)
                {
                    await _next(context);
                    return;
                }
                else
                {
                    context.Response.StatusCode = 404;
                    return;
                }
            }
            catch (Exception e)
            {
         
                context.Response.StatusCode = 404;
                return;
            }
        }
        else
        {
            await _next(context);
        }
    }
}