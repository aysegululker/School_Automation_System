using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class AppUserLoginVM
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Kullanıcı yetkisi boş geçilemez")]
        public string MemberStatus { get; set; }

        public bool RememberMe { get; set; }
    }
}
