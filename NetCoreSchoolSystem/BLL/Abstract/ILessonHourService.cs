using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface ILessonHourService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<LessonHour> GetActiveHour();

        //Listing All (Listeleme)
        List<LessonHour> GetHour(Expression<Func<LessonHour, bool>> exp);

        //Adding (Ekleme)
        void Add(LessonHour lessonHour);

        //Update (Güncelleme)
        void Update(LessonHour lessonHour);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        LessonHour GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<LessonHour, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<LessonHour, bool>> exp);
    }
}
