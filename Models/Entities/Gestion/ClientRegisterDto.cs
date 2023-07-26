using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Models.Entities.Core;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class ClientRegisterDto
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Ville { get; set; }
        public string Tel { get; set; }

        [MinLength(6)]
        public string Password { get; set; }

        [Compare("Password")]

        public string PasswordConfirm { get; set; }

        public bool terms { get; set; }






    }
}