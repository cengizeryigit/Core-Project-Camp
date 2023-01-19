using System.ComponentModel.DataAnnotations;

namespace CoreProjectCamp.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen Rol Adını Giriniz")]
        public string Name { get; set; }
    }
}
