using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AutomotiveApi.Services.Attributes;

public class ValidatIdAgenceAttribute : Attribute, IActionFilter
{
    private string key;
    public ValidatIdAgenceAttribute(string key)
    {
        this.key = key;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var user = context.HttpContext.User;
        var idAgence = int.Parse(user.FindFirst("idAgence").Value);

        if (!context.ActionArguments.TryGetValue(key, out var value)) return;
        if (int.Parse(value.ToString()) != idAgence)
        {
            context.Result = new ObjectResult(new { error = "id agence differente" });
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("on action executed is called");
    }
}