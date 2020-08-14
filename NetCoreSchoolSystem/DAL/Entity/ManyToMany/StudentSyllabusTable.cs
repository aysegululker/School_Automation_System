using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class StudentSyllabusTable:CoreEntity
    {
        public Guid StudentID { get; set; }
        public virtual Student Student { get; set; }

        public Guid SyllabusTableID { get; set; }
        public virtual SyllabusTable SyllabusTable { get; set; }
    }
}
