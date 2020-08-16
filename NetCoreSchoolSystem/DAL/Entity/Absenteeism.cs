using DAL.Entity.Base;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class Absenteeism:CoreEntity
    {
        //This class is defined for Absenteeis Tables. (Bu sınıf öğrencilerin devamsızlıklarını takip etmek için tanımlanmıştır.)

        //public Student SchoolNumber { get; set; }


        public string IsReported { get; set; } //Raporlu mu? Değil mi?


        [Column(TypeName = "Datetime2")]
        public DateTime ReportStartDate { get; set; } //Raporun başlangıç tarihi

        [Column(TypeName = "Datetime2")]
        public DateTime ReportFinishDate { get; set; } //Raporun bitiş tarihi

        
        private double _reportday;
        public double NumberOfDaysWithReport //Raporlu olunan gün sayısı (ondalıklı olabilir)
        {
            get
            {
                return _reportday;
            }
            set
            {

                TimeSpan days = (ReportFinishDate - ReportStartDate);
                var gun = days.TotalDays;
                
                if (gun == 0)
                {
                    _reportday = 0;
                }
                else
                {
                    _reportday = gun;
                }
            }
        }


        public string IsGuardStudent { get; set; }
        private double _guardday;
        [Column(TypeName = "decimal(18,2)")]
        public double NumberOfDaysWithGuardStudent // Nöbetçi öğrenci mi?
        {
            get
            {
                return _guardday;
            }
            set
            {
                if (IsGuardStudent == "Evet")
                {
                    _guardday = 1;
                }
                else
                {
                    _guardday = 0;
                }
            }
        }

        //OneToMany
        public Guid StudentID { get; set; }
        public Student Student { get; set; }

        public Guid ClassRoomID { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
