using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity.OneToMany
{
    public class ClassDefination:CoreEntity
    {
        //This class is assign classes to school floors. (Okulun katlarına sınıfları dağıtmak için)

        public string FloorLocation { get; set; } //Bulunduğu kat

        public Guid PeriodInformationID { get; set; }
        public virtual PeriodInformation PeriodInformation { get; set; } //Ders yılı 2019-2020

        public Guid ClassRoomID { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }

    }
}
