using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion
{
    public interface IOffre
    {
        IEnumerable<Offre> getOffres();
        Offre? findById(int id);
        Offre? add(Offre Offre);
        void delete(int id);
        Offre? update(Offre Offre);
    }
}