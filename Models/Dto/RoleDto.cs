using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class RoleDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public int? IdAgence { get; set; }

        public List<int>? SelectedPermissionIds { get; set; }
    }

}