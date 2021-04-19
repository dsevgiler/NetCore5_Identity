using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5_Identity.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı gereklidir.")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        
        [Display(Name = "Tel No")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email gereklidir.")]
        [Display(Name = "Emailiniz")]
        [EmailAddress(ErrorMessage ="Emailiniz formatı doğru değil.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz gereklidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
