using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class TeacherLesson
    {
        public Guid TeacherID { get; set; }
        public Guid LessonID { get; set; }

        public Teacher Teacher { get; set; }
        public Lesson Lesson { get; set; } 
    }
}
