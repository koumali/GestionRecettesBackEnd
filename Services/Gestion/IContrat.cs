using automotiveApi.Models;

namespace automotiveApi.Services.Gestion
{
    public interface IContrat
    {
        IEnumerable<Contrat> getContrats();
        Contrat? findById(int id);
        Contrat? add(Contrat Contrat);
        void delete(int id);
        Contrat? update(Contrat Contrat);

    }
}