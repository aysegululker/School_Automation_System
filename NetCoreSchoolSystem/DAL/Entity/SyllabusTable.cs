using DAL.Entity.Base;
using DAL.Entity.Enum;
using DAL.Entity.ManyToMany;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class SyllabusTable:CoreEntity
    {
        //Ders Programı

        public WeekDays Day { get; set; } //Gün

        public Guid LessonHourID { get; set; }
        public LessonHour LessonHour { get; set; } //Saat

        public Guid LessonID { get; set; }
        public Lesson Lesson { get; set; } //Ders adı

        public Guid ClassRoomID { get; set; }
        public ClassRoom ClassRoom { get; set; } //Sınıf

        public Guid TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        //ManyToMany
        public virtual List<StudentSyllabusTable> StudentSyllabusTables { get; set; }
        public virtual List<TeacherSyllabusTable> TeacherSyllabusTables { get; set; }
    }
}
