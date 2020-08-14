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
    public class Lesson:CoreEntity
    {
        //This class is defined for creating new lesson. (Yeni ders oluşturmak için tanımlanmıştır.)

        public string LessonName { get; set; } //Ders Adı

        public string SubLessonName { get; set; } //Alt Ders Adı

        public LessonCat LessonCategory { get; set; } //Karnede gösterilecek kategori

        public int WeeklyLessonHour { get; set; } //Haftada kaç saat

        //First exam note weight. İlk sınavın not ağırlığı
        //public string MidTermExam1 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MidTermNoteWeight1 { get; set; }


        //Second exam note weight. Ara sınavın not ağırlığı
        //public string MidTermExam2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MidTermNoteWeight2 { get; set; }


        //First exam note weight. İlk sınavın not ağırlığı
        //public string FinalExam { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FinalExamNoteWeight { get; set; }

        //ManyToMany
        public virtual List<StudentLesson> StudentLessons { get; set; } //A lesson has more than one student. For the elective course (bir dersin birden fazla öğrencisi vardır. Seçmeli ders için) 

        public virtual List<TeacherLesson> TeacherLessons { get; set; } //A teacher can take more than one class. (Bir öğretmen birden fazla derse girebilir. Beden eğitimi hocasının Trafik dersine girmesi gibi.

    }
}
