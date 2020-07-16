using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity.OneToMany
{
    public class Branch:CoreEntity
    {
        //This class is defined for creating branch. (Branş oluşturmak için tanımlanmıştır.)

        public string BranchName { get; set; }

        
    }
}
