using DAL.Entity.Base;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.ManyToMany
{
    public class RoomLessonTeacher:CoreEntity
    {
        //Sınıflara, öğretmen ve ders atamak için oluşturulmuş tablodur

        public Guid ClassRoomID { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }

        public Guid LessonID { get; set; }
        public virtual Lesson Lesson { get; set; }

        public Guid TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }

        public Guid BranchID { get; set; }
        public virtual Branch Branch { get; set; }

    }
}
