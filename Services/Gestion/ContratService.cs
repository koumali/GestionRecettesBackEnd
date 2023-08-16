using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Gestion;

public class ContratService : GenericDataService<Contrat>, IContrat
{
    private readonly AppDbContext _context;

    public ContratService(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public new async Task<Contrat> CreateAsync(Contrat contrat)
    {
        Contrat newCont = await base.CreateAsync(contrat);

        return _context.Contrats
            .Include(c => c.Client)
            .Include(r => r.Reservation)
            .FirstOrDefault(c => c.Id == newCont.Id);
    }



    public new async Task<IEnumerable<Contrat>> GetAllAsync()
    {
        return await _context.Contrats
            .Include(c => c.Client)
            .Include(r => r.Reservation)
            .ToListAsync();
    }

    public async Task<Contrat> DeleteContrat(int id)
    {
        Contrat? contrat = await _context.Contrats.FirstOrDefaultAsync(c => c.Id == id);

        if (contrat == null)
        {
            throw new Exception("Contrat not found");
        }

        _context.Contrats.Remove(contrat);
        await _context.SaveChangesAsync();

        return contrat;
    }

}