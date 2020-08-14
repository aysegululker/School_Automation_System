using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity
{
    public class AppUser:IdentityUser<Guid>
    {
        //You should download "install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore" package for the identity library

        public string FirstName { get; set; }
        public string SurName { get; set; } 
        public string MemberStatus { get; set; }


        [StringLength(11, ErrorMessage = "TC Kimlik Numaraları 11 hanelidir.")]
        public string IdentificationNumber { get; set; }
    }
}
