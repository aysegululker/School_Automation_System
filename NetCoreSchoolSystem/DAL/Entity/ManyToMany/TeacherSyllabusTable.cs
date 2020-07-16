using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class TeacherSyllabusTable
    {
        public Guid TeacherID { get; set; }
        public Guid SyllabusTableID { get; set; }

        public Teacher Teacher { get; set; }
        public SyllabusTable SyllabusTable { get; set; }

    }
}
