using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class PeriodInformation:CoreEntity
    {
        //This class is defined for period knowledge. (Yeni dönem oluşturmak için tanımlanmıştır.)

        public string LessonYear { get; set; } //Ders Yılı

        public string PeriodName { get; set; } //Dönem Adı...1.Dönem - 2.Dönem

        [Column(TypeName = "Datetime2")]
        public DateTime PeriodStartDate { get; set; } //Dönem Başlangıç Tarihi

        [Column(TypeName = "Datetime2")]
        public DateTime PeriodFinishDate { get; set; } //Dönem Bitiş Tarihi

    }
}
