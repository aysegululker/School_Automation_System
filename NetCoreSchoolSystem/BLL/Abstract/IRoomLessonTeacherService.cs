using DAL.Entity.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IRoomLessonTeacherService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<RoomLessonTeacher> GetActiveRoomLessonTeacher();

        //Listing All (Listeleme)
        List<RoomLessonTeacher> GetRoomLessonTeacher(Expression<Func<RoomLessonTeacher, bool>> exp);

        //Adding (Ekleme)
        void Add(RoomLessonTeacher roomLessonTeacher);

        //Update (Güncelleme)
        void Update(RoomLessonTeacher roomLessonTeacher);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        RoomLessonTeacher GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<RoomLessonTeacher, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<RoomLessonTeacher, bool>> exp);
    }
}
