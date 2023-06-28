using automotiveApi.Models;

namespace automotiveApi.Services.Gestion
{
    public interface IAgence
    {
        IEnumerable<Agence> getAgences();
        Agence? findById(int id);
        Agence? add(Agence agence);
        void delete(int id);
        Agence? update(Agence agence);



    }
}