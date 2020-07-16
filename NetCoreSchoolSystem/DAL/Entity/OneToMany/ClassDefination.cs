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

        public PeriodInformation LessonYear { get; set; } //Ders yılı 2019-2020
        public string FloorLocation { get; set; } //Bulunduğu kat
        public int Capacity { get; set; } //Sınıf kapasitesi


        //OneToMany
        public virtual List<ClassRoom> ClassRooms { get; set; } //Bir katta birden fazla sınıf olabilir
    }
}
