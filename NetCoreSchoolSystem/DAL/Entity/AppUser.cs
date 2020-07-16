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

        [StringLength(11, ErrorMessage ="TC Kimlik Numaraları 11 hanelidir.")]
        public string IdentificationNumber { get; set; }

        public string SchoolNumber { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; } 
        public string Gender { get; set; }

    }
}
