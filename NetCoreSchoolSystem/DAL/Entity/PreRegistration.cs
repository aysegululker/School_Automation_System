using DAL.Entity.Base;
using DAL.Entity.OneToMany;
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

        private static int _recordNumber = 99;
        public int RecordNumber 
        {
            get
            {
                _recordNumber++;
                return _recordNumber;
            } 
        }

        private string _prenumber;
        public string PreSchoolNumber
        {
            get
            {
                return _prenumber;
            }
            set
            {
                var yil = DateTime.Now.Year;
                var sonuc = "pre" + "-" + RecordNumber.ToString() + "-" + yil.ToString().Substring(2);
                _prenumber = sonuc;
            }

        }

        public string TheEndSchool { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastGradeAverage { get; set; }
        public string ParentName { get; set; }
        public string ParentCellPhone { get; set; }
        public bool ClassAssignment { get; set; }


        //One To Many
        public Guid PeriodInformationID { get; set; }
        public PeriodInformation PeriodInformation { get; set; }

        public Guid ClassRoomID { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
