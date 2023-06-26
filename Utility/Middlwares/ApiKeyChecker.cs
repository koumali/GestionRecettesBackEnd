using Microsoft.Extensions.Primitives;

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

        Console.WriteLine("HeaderKeyName: " + HeaderKeyName);

        //GET VALUE FROM HEADER
        StringValues headerValues;
        context.Request.Headers.TryGetValue(HeaderKeyName, out headerValues);
        string headerValue = headerValues.FirstOrDefault() ?? "";

        Console.WriteLine("headerValue: " + headerValue);
        
        if (headerValue != key)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Invalid API Key");
            return;
        }

        await _next(context);


    }
}