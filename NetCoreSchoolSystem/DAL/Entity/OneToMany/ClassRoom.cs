using DAL.Entity.Base;
using DAL.Entity.ManyToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Text;

namespace DAL.Entity.OneToMany
{
    public class ClassRoom:CoreEntity
    {
        //This class is defined for classroom. (Yeni sınıf oluşturmak için)

        
        public string Room { get; set; } //9, 10, 11, 12
        public string ClassDepartment { get; set; } //A - B - C

        public string RoomDepartment 
        {
            get
            {
                var sonuc = Room + "-" + ClassDepartment;
                return sonuc;
            }
        }

        public int Capacity { get; set; } //Sınıf kapasitesi

        //OneToMany
        public virtual List<Student> Students { get; set; } // A class has more than one student. (bir sınıfta birden fazla öğrencisi vardır.)

        //ManyToMany
        public virtual List<TeacherClassRoom> TeacherClassRooms { get; set; } //A class has more than one teacher. (Bir sınıfın birden fazla öğretmeni vardır.)


    }
}
