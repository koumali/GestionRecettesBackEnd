using Microsoft.Extensions.Primitives;

namespace AutomotiveApi.Utility.Middlwares;

public class ApiKeyChecker
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;

    public ApiKeyChecker(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        string HeaderKeyName = _configuration["ApiKey:HeaderName"] ?? "";
        string key = _configuration["ApiKey:KeyValue"] ?? "";


        //GET VALUE FROM HEADER
        StringValues headerValues;
        context.Request.Headers.TryGetValue(HeaderKeyName, out headerValues);
        string headerValue = headerValues.FirstOrDefault() ?? "";


        if (headerValue != key)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Invalid API Key");
            return;
        }

        await _next(context);
    }
}