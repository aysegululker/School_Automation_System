using DAL.Entity.Base;
using DAL.Entity.ManyToMany;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class Teacher:CoreEntity
    {
        //This class is defined for creating new teacher. (Yeni öğretmen oluşturmak için tanımlanmıştır.)
        public Guid BranchID { get; set; }

        //OneToMany
        public virtual Branch Branch { get; set; } //A Branch has more than one teacher. (Bir branşın birden fazla öğretmeni vardır.)

        //ManyToMany
        public virtual List<TeacherNoteEntry> TeacherNoteEntries { get; set; }
        public virtual List<TeacherSyllabusTable> TeacherSyllabusTables { get; set; } 
        public virtual List<StudentTeacher> StudentTeachers { get; set; } //A teacher has more than one student (Bir öğretmenin birden fazla öğrencisi vardır.)
        public virtual List<TeacherClassRoom> TeacherClassRooms { get; set; } //A teacher has more than one class (Bir öğretmenin birden fazla sınıfı vardır.)
        public virtual List<TeacherLesson> TeacherLessons { get; set; } //A teacher can take more than one class. (Bir öğretmen birden fazla derse girebilir. Beden eğitimi hocasının Trafik dersine girmesi gibi.
    }
}
