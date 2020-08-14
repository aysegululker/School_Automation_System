using DAL.Entity;
using DAL.Entity.ManyToMany;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Ogretmen.Models.ViewModels
{
    public class TeacherSyllabusTableVM
    {
        public List<TeacherSyllabusTable> TeacherSyllabusTables { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<SyllabusTable> SyllabusTables { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<LessonHour> LessonHours { get; set; }
    }
}
