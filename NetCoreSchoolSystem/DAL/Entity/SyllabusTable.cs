using DAL.Entity.Base;
using DAL.Entity.Enum;
using DAL.Entity.ManyToMany;
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

        public WeekDays WeekDays { get; set; } //Gün
        public LessonHour LessonHour { get; set; } //Saat
        public Lesson LessonName { get; set; } //Ders adı

        //ManyToMany
        public virtual List<StudentSyllabusTable> StudentSyllabusTables { get; set; }
        public virtual List<TeacherSyllabusTable> TeacherSyllabusTables { get; set; }
    }
}
