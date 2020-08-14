using DAL.Entity;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Admin.Models.ViewModels
{
    public class PreRegistrationVM
    {
        public List<PreRegistration> PreRegistrations { get; set; }
        public List<PeriodInformation> PeriodInformations { get; set; }
        public List<ClassRoom> ClassRooms { get; set; }
        public List<Student> Students { get; set; }
    }
}
