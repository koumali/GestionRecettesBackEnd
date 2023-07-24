using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using Bogus;

namespace AutomotiveApi.DAL
{
    public class DataSeeder
    {
        public static Faker<Agence>? seedAgence()
        {
            var id = 1;
            var agences = new Faker<Agence>()
            .RuleFor(x => x.Id, f => id++).RuleFor(x => x.Name, f => f.Name.JobTitle())
            .RuleFor(x => x.Tel, f => f.Phone.PhoneNumber())
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.Address, f => f.Address.StreetAddress())
            .RuleFor(x => x.City, f => f.Address.City())
            .RuleFor(x => x.ZipCode, f => f.Address.ZipCode())
            .RuleFor(x => x.Latitude, f => f.Address.Latitude())
            .RuleFor(x => x.Longitude, f => f.Address.Longitude())
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return agences;
        }

        public static Faker<Client> seedClient(AppDbContext context)
        {
            var id = 1;
            var clients = new Faker<Client>()
            .RuleFor(x => x.Id, f => id++).RuleFor(x => x.FirstName, f => f.Name.FirstName())
            .RuleFor(x => x.LastName, f => f.Name.LastName())
            .RuleFor(x => x.Tel, f => f.Phone.PhoneNumber())
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.Ville, f => f.Address.City())
            .RuleFor(x => x.ZipCode, f => f.Address.ZipCode())
            .RuleFor(x => x.Adresse, f => f.Address.StreetAddress())
            .RuleFor(x => x.Adresse2, f => f.Address.StreetAddress())
            .RuleFor(x => x.PermisRecto, f => f.Image.PicsumUrl())
            .RuleFor(x => x.PermisVerso, f => f.Image.PicsumUrl())
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return clients;
        }

        public static Faker<Marque> seedMarque()
        {
            var id = 1;
            var marques = new Faker<Marque>()
            .RuleFor(x => x.Id, f => id++).RuleFor(x => x.Name, f => f.Vehicle.Manufacturer())
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return marques;
        }
        public static Faker<LongTermRental> seedLongTermRental()
        {
            var id = 1;
            var marques = new Faker<LongTermRental>()
            .RuleFor(x => x.Id, f => id++)
            .RuleFor(x => x.nom, f => f.Name.FirstName())
            .RuleFor(x => x.email, f => f.Internet.Email())
            .RuleFor(x => x.ville, f => f.Address.City())
            .RuleFor(x => x.prenom, f => f.Name.LastName())
            .RuleFor(x => x.phone, f => f.Phone.PhoneNumber())
            .RuleFor(x => x.description, f => f.Name.LastName())
            .RuleFor(x => x.entreprise, f => f.Company.CompanyName())
            .RuleFor(x => x.zip, f => f.Address.ZipCode())
            .RuleFor(x => x.duree, f => id)
            .RuleFor(x => x.type_vehicule, id)
            .RuleFor(x => x.NumeroReservation,f => f.Name.FirstName())
            .RuleFor(x => x.status,f => f.Name.FirstName())
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return marques;
        }

        public static Faker<Modele> seedModele()
        {
            var id = 1;
            var modeles = new Faker<Modele>()
            .RuleFor(x => x.Id, f => id++).RuleFor(x => x.Name, f => f.Vehicle.Model())
            .RuleFor(x => x.IdMarque, f => f.Random.Int(1, 10))
            .RuleFor(x => x.Image, f => f.Image.PicsumUrl())
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return modeles;
        }

        public static Faker<User> seedUser()
        {
            var id = 1;
            var Users = new Faker<User>()
            .RuleFor(x => x.Id, f => id++).RuleFor(x => x.FirstName, f => f.Name.FirstName())
            .RuleFor(x => x.LastName, f => f.Name.LastName())
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.Password, f => BCrypt.Net.BCrypt.HashPassword("user123" + (id - 1)))
            .RuleFor(x => x.IdRole, f => f.Random.Int(1, 4))
            .RuleFor(x => x.IsActive, f => f.Random.Bool())
            .RuleFor(x => x.IdAgence, f => f.Random.Int(1, 10))
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return Users;

        }


    }
}