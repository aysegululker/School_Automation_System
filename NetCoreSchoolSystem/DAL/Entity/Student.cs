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
    public class Student:CoreEntity
    {
        //This class is defined for creating new student. (Yeni öğrenci oluşturmak için tanımlanmıştır.)

        

        private static int _recordNumber = 100;
        public int RecordNumber
        {
            get
            {
                return _recordNumber;
            }
        }

        private string _number;
        public string SchoolNumber
        {
            get
            {
                return _number;
            }
            set
            {
                var yil = DateTime.Now.Year;
                var sonuc = RecordNumber.ToString() + "-" + yil.ToString().Substring(2);
                if(value == sonuc)
                {
                    _number = value;
                }
                else
                {
                    _number = RecordNumber.ToString() + "-" + yil.ToString().Substring(2);
                }
                _recordNumber++;

            }
        }

        public PeriodInformation LessonYear { get; set; }
        public string ContinueStatus { get; set; }

        
        [Column(TypeName = "decimal(18,2)")]
        public decimal YearEndAverage { get; set; } //Yıl sonu not ortalaması
        [Column(TypeName = "decimal(18,2)")]
        public decimal GeneralAverage { get; set; } //Genel Ortalama

        public string ParentName { get; set; } //Veli Adı - Soyadı
        public string ParentCellPhone { get; set; } //Velinin Cep Telefonu
        public string JobPhone { get; set; } //İş telefonu


        //OneToMany
        public Guid ClassRoomID { get; set; }
        public virtual ClassRoom ClassRoom { get; set; } //A student has one classroom. (Bir öğrencinin bir sınıfı vardır.)

        public virtual PreRegistration PreRegistration { get; set; }
        //public virtual List<Absenteeism> Absenteeisms { get; set; } //A student has more than one absenteeism (bir öğrencinin birden fazla devamsızlığı vardır)



        //ManyToMany
        public virtual List<StudentSuccessDocument> StudentSuccessDocuments { get; set; } //A student has more than one sucdocument. (Bir öğrencinin birden fazla başarı belgesi olabilir. Takdir + Onur Belgesi)
        public virtual List<StudentSyllabusTable> StudentSyllabusTables { get; set; }
        public virtual List<StudentTeacher> StudentTeachers { get; set; } //A student has more than one teacher (bir öğrencinin birden fazla öğretmeni vardır)
        public virtual List<StudentLesson> StudentLessons { get; set; } //A student has more than one lesson (bir öğrencinin birden fazla dersi vardır)
    }
}
