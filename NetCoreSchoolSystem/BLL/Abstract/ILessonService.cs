using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface ILessonService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<Lesson> GetActiveLesson();

        //Listing All (Listeleme)
        List<Lesson> GetLesson(Expression<Func<Lesson, bool>> exp);

        //Adding (Ekleme)
        void Add(Lesson lesson);

        //Update (Güncelleme)
        void Update(Lesson lesson);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        Lesson GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<Lesson, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<Lesson, bool>> exp);
    }
}
