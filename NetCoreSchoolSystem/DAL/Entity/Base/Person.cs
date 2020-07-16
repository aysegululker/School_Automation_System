using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity.Base
{
    public class Person
    {
        public string IdentificationNumber { get; set; } //TC Kimlik No
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public string FullName
        {
            get
            {
                return (FirstName + " " + SurName);
            }
        }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public string HomeAddress { get; set; }
        public string Province { get; set; } //İl
        public string District { get; set; } //İlçe
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ImagePath { get; set; }

    }
}
