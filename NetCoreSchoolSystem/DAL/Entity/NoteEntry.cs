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

        [Column(TypeName = "decimal(18,2)")]
        public decimal MidTermExam1Score { get; set; } //1. Sınavına ait ders notu

        [Column(TypeName = "decimal(18,2)")]
        public decimal MidTermExam2Score { get; set; } //Ara Sınavına ait ders notu

        [Column(TypeName = "decimal(18,2)")]
        public decimal FinalExamScore { get; set; } //Final sınavına ait ders notu


        [Column(TypeName = "decimal(18,2)")]
        public decimal AverageScore { get; set; }


        public Guid TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }

        public Guid PeriodInformationID { get; set; }
        public virtual PeriodInformation PeriodInformation { get; set; }

        public Guid ClassRoomID { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }

        public Guid StudentID { get; set; }
        public virtual Student Student { get; set; }

        public Guid LessonID { get; set; }
        public virtual Lesson Lesson { get; set; }

        //ManyToMany
        public virtual List<TeacherNoteEntry> TeacherNoteEntries { get; set; }

    }
}
