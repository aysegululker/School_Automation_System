﻿using DAL.Entity;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Ogrenci.Models.ViewModels
{
    public class StudentSyllabusTableVM
    {
        public List<SyllabusTable> SyllabusTables { get; set; }
        public List<LessonHour> LessonHours { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
    }
}
