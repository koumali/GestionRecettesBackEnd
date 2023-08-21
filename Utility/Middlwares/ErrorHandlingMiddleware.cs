using System.Net;
using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;
using Newtonsoft.Json;

namespace AutomotiveApi.Utility.Middlwares;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;

    }

    public async Task Invoke(HttpContext context /* other scoped dependencies */)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {

            // get response status code
            var code = HttpStatusCode.InternalServerError; // 500 

            if (exception is UnauthorizedAccessException) code = HttpStatusCode.Unauthorized;
            else if (exception is BadHttpRequestException) code = HttpStatusCode.BadRequest;
            else if (exception is Exception) code = HttpStatusCode.InternalServerError;

            // get database context


            if (code == HttpStatusCode.InternalServerError)
            {
                try
                {
                    Console.WriteLine("Error: " + exception.Message);
                    var _context = context.RequestServices.GetRequiredService<AppDbContext>();

                    await _context.log_journal.AddAsync(new Log_journal
                    {
                        NameController = context.Request.Path,
                        NameFonction = context.Request.Method,
                        DescriptionMessage = exception.Message,
                        CreatedAt = DateTime.Now
                    });
                   await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            var result = JsonConvert.SerializeObject(new { errors = exception});
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            await context.Response.WriteAsync(result);
        }
    }


}