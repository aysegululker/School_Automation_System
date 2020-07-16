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
        public ClassRoom ClassRoom { get; set; }
        public ClassRoom ClassDepartment { get; set; }
        public bool IsReported { get; set; } //Raporlu mu? Değil mi?

        [Column(TypeName = "Datetime2")]
        public DateTime ReportStartDate { get; set; } //Raporun başlangıç tarihi
        [Column(TypeName = "Datetime2")]
        public DateTime ReportFinishDate { get; set; } //Raporun bitiş tarihi

        private decimal _reportday;
        [Column(TypeName = "decimal(18,2)")]
        public decimal NumberOfDaysWithReport //Raporlu olunan gün sayısı (ondalıklı olabilir)
        {
            get
            {
                return _reportday;
            }
            set
            {
                var gun = ReportFinishDate - ReportStartDate;
                var sonuc = decimal.Parse(gun.ToString());

                if (IsReported == false)
                {
                    _reportday = 0;
                }
                else
                {
                    _reportday = sonuc;
                }
            }
        }


        public bool IsGuardStudent { get; set; }
        private decimal _guardday;
        [Column(TypeName = "decimal(18,2)")]
        public decimal NumberOfDaysWithGuardStudent // Nöbetçi öğrenci mi?
        {
            get
            {
                return _guardday;
            }
            set
            {
                if (IsGuardStudent == false)
                {
                    _guardday = 0;
                }
                else
                {
                    _guardday = 1;
                }
            }
        }

        //OneToMany
        public Student Student { get; set; }
    }
}
