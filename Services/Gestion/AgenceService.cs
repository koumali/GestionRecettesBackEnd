using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;

namespace AutomotiveApi.Services.Gestion
{
    public class AgenceService : GenericDataService<Agence>, IAgence
    {
        public AgenceService(AppDbContext db) : base(db)
        {
        }
    }
}