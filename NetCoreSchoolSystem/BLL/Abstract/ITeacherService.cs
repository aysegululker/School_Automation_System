using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface ITeacherService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<Teacher> GetActiveTeacher();

        //Listing All (Listeleme)
        List<Teacher> GetTeacher(Expression<Func<Teacher, bool>> exp);

        //Adding (Ekleme)
        void Add(Teacher teacher);

        //Update (Güncelleme)
        void Update(Teacher teacher);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        Teacher GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<Teacher, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<Teacher, bool>> exp);
    }
}
