using DAL.Entity;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Admin.Models.ViewModels
{
    public class AbsenteeismVM
    {
        public List<Absenteeism> Absenteeisms { get; set; }
        public List<Student> Students { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
    }
}
