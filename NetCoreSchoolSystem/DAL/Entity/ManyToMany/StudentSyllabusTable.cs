using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class StudentSyllabusTable
    {
        public Guid StudentID { get; set; }
        public Guid SyllabusTableID { get; set; }

        public Student Student { get; set; }
        public SyllabusTable SyllabusTable { get; set; }
    }
}
