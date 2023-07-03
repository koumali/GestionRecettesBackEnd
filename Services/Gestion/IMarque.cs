using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Services.Gestion
{
    public interface IMarque
    {
        IEnumerable<Marque> getMarques();
        Marque? findById(int id);
        Marque? add(Marque marque);
        void delete(int id);
        Marque? update(Marque marque);
    }
}