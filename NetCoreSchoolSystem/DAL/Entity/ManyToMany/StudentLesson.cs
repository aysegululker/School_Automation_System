using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class StudentLesson
    {
        //For the elective course(bir dersin birden fazla öğrencisi vardır. Seçmeli ders için)

        public Guid StudentID { get; set; }
        public Guid LessonID { get; set; }

        public Student Student { get; set; }
        public Lesson Lesson { get; set; }

    }
}
