using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class StudentTeacher:CoreEntity
    {
        public Guid StudentID { get; set; }
        public Guid TeacherID { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }

    }
}
