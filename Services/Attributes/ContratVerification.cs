using AutomotiveApi.DAL;
using AutomotiveApi.Services.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Attributes;

public class ContratVerification : Attribute, IActionFilter
{
    private string contratId;

    public ContratVerification(string key)
    {
        this.contratId = key;

    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        AppDbContext? _context = context.HttpContext.RequestServices.GetService(typeof(AppDbContext)) as AppDbContext;
        var user = context.HttpContext.User;
        var idAgence = int.Parse(user.FindFirst("idAgence").Value);

        if (!context.ActionArguments.TryGetValue(contratId, out var value)) return;

        int id = int.Parse(value.ToString());

        bool contrat = _context.Contrats.Where(c => c.Id == id && c.Reservation.Vehicule.IdAgence == idAgence).Any();        

        if (!contrat)
        {
            context.Result = new ObjectResult(new { errors = "id agence differente" });
        }

    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("on action executed is called");
    }
}