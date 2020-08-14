using DAL.Entity.Base;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class TeacherClassRoom:CoreEntity
    {
        public Guid TeacherID { get; set; }
        public Guid ClassRoomID { get; set; }

        public Teacher Teacher { get; set; }
        public ClassRoom ClassRoom { get; set; }

    }
}
