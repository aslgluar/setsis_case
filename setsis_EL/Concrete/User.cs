using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_EL.Concrete
{
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen E-mailinizi giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string Password { get; set; }
        public string EmailConfirmed { get; set; }
        public string PasswordConfirmed { get; set; }

    }
}
