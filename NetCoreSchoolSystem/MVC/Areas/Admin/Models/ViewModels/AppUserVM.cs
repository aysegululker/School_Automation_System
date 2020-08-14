using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Admin.Models.ViewModels
{
    public class AppUserVM
    {
        [Required(ErrorMessage = "Ad boş geçilemez.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Soyadı boş geçilemez.")]
        public string SurName { get; set; }



        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez.")]
        public string UserName { get; set; }



        [Required(ErrorMessage = "Şifre boş geçilemez.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "TC No giriniz.")]
        [Compare("UserName", ErrorMessage = ("UserName ile TC No'nun aynı olması gerekmektedir."))]
        public string IdentificationNumber { get; set; }



        [Required(ErrorMessage = "Kullanıcı Statüsü boş geçilemez.")]
        public string MemberStatus { get; set; }

        public List<AppUserRole> AppUSerRoles { get; set; }
    }
}
