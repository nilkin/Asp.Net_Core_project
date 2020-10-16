using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CorporX.Areas.Manager.ViewModels
{
    public class LoginViewModel
    {
        [DisplayName("Email")]
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
