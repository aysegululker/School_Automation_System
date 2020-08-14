using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class TeacherSyllabusTable:CoreEntity
    {
        public Guid TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }

        public Guid SyllabusTableID { get; set; }
        public virtual SyllabusTable SyllabusTable { get; set; }

    }
}
