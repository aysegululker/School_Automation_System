using DAL.Entity;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Admin.Models.ViewModels
{
    public class TeacherVM
    {
        public List<Teacher> Teachers { get; set; }
        public List<Branch> Branches { get; set; }
    }
}
