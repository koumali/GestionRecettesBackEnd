using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Utility;
using Bogus;

namespace AutomotiveApi.DAL
{
    public class DataSeeder
    {

        public static IEnumerable<Permission> SeedPermissions()
        {
            var permissions = Enum.GetValues<PredefinedPermissions>()
                .Select(p => new Permission
                {
                    Id = (int)p,
                    Name = p.ToString()
                });
            return permissions;
        }


        public static IEnumerable<Role> SeedRoles()
        {
            var roles = new List<Role>
            {
                new Role
                {
                    Id = 1,
                    Name = "SuperAdmin",
                    

                },
                new Role
                {
                    Id = 2,
                    Name = "Admin",

                }
            };
            return roles;
        }

        public static IEnumerable<RolePermission> SeedRolePermissions()
        {
            var rolePermissions = new List<RolePermission>{
                new RolePermission{
                    Id=1,
                    IdRole=1,
                    IdPermission=1
                },
                new RolePermission{
                    Id=2,
                    IdRole=1,
                    IdPermission=2
                },
                new RolePermission{
                    Id=3,
                    IdRole=1,
                    IdPermission=3
                },
                new RolePermission{
                    Id=4,
                    IdRole=1,
                    IdPermission=4
                },
                new RolePermission{
                    Id=5,
                    IdRole=2,
                    IdPermission=7
                }};

            return rolePermissions;

        }


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

        public static Faker<Client> seedClient()
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

        public static Faker<LongTermRental> seedLongTermRental()
        {
            var id = 1;

            var lld = new Faker<LongTermRental>()
            .RuleFor(x => x.Id, f => id++)
            .RuleFor(x => x.nom, f => f.Name.FirstName())
            .RuleFor(x => x.email, f => "RyanGosling@drive.com")
            .RuleFor(x => x.ville, f => f.Address.City())
            .RuleFor(x => x.prenom, f => f.Name.LastName())
            .RuleFor(x => x.phone, f => f.Phone.PhoneNumber())
            .RuleFor(x => x.description, f => f.Name.LastName())
            .RuleFor(x => x.entreprise, f => f.Company.CompanyName())
            .RuleFor(x => x.zip, f => f.Address.ZipCode())
            .RuleFor(x => x.duree, f => f.Random.Int(18, 33))
            .RuleFor(x => x.IdModele, f => f.Random.Int(1, 326))
            .RuleFor(x => x.NumeroReservation, f => f.Random.String2(10))
            .RuleFor(x => x.status, f => "Enattente")
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return lld;
        }

        // seed vehicules

        public static Faker<Vehicule> seedVehicule()
        {


            // modeles ids from json file

            var id = 1;
            var vehicules = new Faker<Vehicule>()
            .RuleFor(x => x.Id, f => id++)
            .RuleFor(x => x.IdModele, f => f.Random.Int(1, 326))
            .RuleFor(x => x.IdAgence, f => f.Random.Int(1, 10))
            .RuleFor(x => x.Prix, f => f.Random.Int(1, 10))
            .RuleFor(x => x.Matricule, f => f.Random.String2(10))
            .RuleFor(x => x.Km, f => f.Random.Int(1, 10000))
            .RuleFor(x => x.Moteur, f => f.Random.String2(10))
            .RuleFor(x => x.Gearbox, f => f.Random.String2(10))
            .RuleFor(x => x.NbPassager, f => f.Random.Int(1, 10))
            .RuleFor(x => x.NbPort, f => f.Random.Int(1, 10))
            .RuleFor(x => x.Name, f => f.Random.String2(10))
            .RuleFor(x => x.Type, f => f.Random.String2(10))
            .RuleFor(x => x.Climat, f => f.Random.Bool())
            .RuleFor(x => x.Airbag, f => f.Random.Bool())
            .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return vehicules;
        }

        // seed offres
        public static Faker<Offre> seedOffre()
        {
            var id = 1;
            var offres = new Faker<Offre>()
            .RuleFor(x => x.Id, f => id++)
            .RuleFor(x => x.IdVehicule, f => f.Random.Int(1, 10))
            .RuleFor(x => x.isPublic, f => f.Random.Bool())
            .RuleFor(x => x.Prix, f => f.Random.Int(1, 10))
            .RuleFor(x => x.DateDebut, f => f.Date.Soon())
            .RuleFor(x => x.DateFin, f => f.Date.Future())
            .RuleFor(x => x.CreatedAt, f => f.Date.Recent());

            return offres;
        }


        public static Faker<Reservation> seedReservation()
        {
            var id = 1;
            string[] status = { "Confirmé", "Enattente", "Annulé", "Expiré" };
            var reservations = new Faker<Reservation>()
            .RuleFor(x => x.Id, f => id++)
            .RuleFor(x => x.IdVehicule, f => f.Random.Int(1, 10))
            .RuleFor(x => x.DateDepart, f => f.Date.Soon())
            .RuleFor(x => x.DateRetour, f => f.Date.Future())
            .RuleFor(x => x.CreatedAt, f => f.Date.Recent())
            .RuleFor(x => x.NumeroReservation, f => Guid.NewGuid().ToString())
            .RuleFor(x => x.Status, f => f.PickRandom(status));

            return reservations;
        }

        // seed contrats
        public static Faker<Contrat> seedContrat()
        {
            var id = 1;
            var contrats = new Faker<Contrat>()
            .RuleFor(x => x.Id, f => id++)
            .RuleFor(x => x.IdReservation, f => f.Random.Int(1, 10))
            .RuleFor(x => x.IdClient, f => f.Random.Int(1, 10))
            .RuleFor(x => x.IsConducteur, f => f.Random.Bool());

            return contrats;
        }




        public static Faker<User> seedUser()
        {
            var id = 1;
            var Users = new Faker<User>()
                .RuleFor(x => x.Id, f => id++).RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Email, f => f.Internet.Email())
                .RuleFor(x => x.Password, f => BCrypt.Net.BCrypt.HashPassword("user123" + (id - 1)))
                .RuleFor(x => x.IdRole, f => f.Random.Int(1, 2))
                .RuleFor(x => x.IsActive, f => f.Random.Bool())
                .RuleFor(x => x.IdAgence, f => f.Random.Int(1, 10))
                .RuleFor(x => x.CreatedAt, f => f.Date.Past());

            return Users;
        }



    }
}