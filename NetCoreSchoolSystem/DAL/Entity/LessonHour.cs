using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class LessonHour:CoreEntity
    {
        //This class is defined for creating lesson hour. (Ders saati oluşturmak için tanımlanmıştır.)

        //02:00
        public TimeSpan StartHour { get; set; }
        public TimeSpan FinishHour { get; set; }
        public string LesHour 
        {
            get
            {
                var sonuc = StartHour + " - " + FinishHour;
                return sonuc;
            }
        }
    }
}
