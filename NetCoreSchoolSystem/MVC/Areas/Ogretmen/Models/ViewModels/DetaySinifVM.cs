using DAL.Entity;
using DAL.Entity.ManyToMany;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Ogretmen.Models.ViewModels
{
    public class DetaySinifVM
    {
        public List<ClassRoom> ClassRooms { get; set; }
        public List<Student> Students { get; set; }
    }
}
