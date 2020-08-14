using DAL.Entity;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Admin.Models.ViewModels
{
    public class StudentVM
    {
        public List<Student> Students { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
        public List<PreRegistration> PreRegistrations { get; set; }
    }
}
