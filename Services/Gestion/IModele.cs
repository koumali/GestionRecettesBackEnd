using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion
{
    public interface IModele
    {
        IEnumerable<Modele> getModeles();
        Modele? findById(int id);
        Modele? add(Modele Modele);
        void delete(int id);
        Modele? update(Modele Modele);
    }
}