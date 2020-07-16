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
    public class NoteEntry:CoreEntity
    {
        //This class is defined for Note Entry Tables. (Bu sınıf not girişleri için tanımlanmıştır.)

        public Student SchoolNumber { get; set; } //Okul No
        public ClassRoom ClassRoom { get; set; } //Sınıf 9, 10, 11
        public ClassRoom ClassDepartment { get; set; } // A - B - C
        public Student StudentName { get; set; } //Öğrenci adı
        public Student StudentSurName { get; set; } //Öğrenci soyadı
        public Lesson LessonName { get; set; } //Ders adı
        public PeriodInformation LessonYear { get; set; } //Ders Yılı
        public PeriodInformation PeriodName { get; set; } //Dönem Adı...1.Dönem - 2.Dönem
        public string ExamType { get; set; } //Sınav türü. vize - final
        [Column(TypeName = "decimal(18,2)")]
        public decimal LessonScore { get; set; } //Ders Notu
        public Teacher TeacherFirstName { get; set; } //Öğretmen adı
        public Teacher TeacherSurName { get; set; } //Öğretmen soyadı


        //ManyToMany
        public virtual List<TeacherNoteEntry> TeacherNoteEntries { get; set; }

    }
}
