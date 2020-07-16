using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class PreRegistration:CoreEntity
    {
        //This class is defined in order to be able to pre-register students. (Bu sınıf öğrencilerin ön kaydını yapabilmek için tanımlanmıştır.)


        public PeriodInformation LessonYear { get; set; }

        private string _prenumber;
        public string PreSchoolName
        {
            get
            {
                return _prenumber;
            }
            set
            {
                var yil = DateTime.Now.Year;
                var deger = 100;
                var sonuc = "pre" + "-" + deger + "-" + yil;

                if (value != sonuc)
                {
                    _prenumber = sonuc;
                }
                else
                {
                    deger++;
                    _prenumber = deger + "-" + yil;
                }
            }
        }

        public string TheEndSchool { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastGradeAverage { get; set; }
        public string ParentName { get; set; }
        public string JobPhone { get; set; }
        public bool ClassAssignment { get; set; }

    }
}
