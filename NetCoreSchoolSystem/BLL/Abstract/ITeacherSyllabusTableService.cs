using DAL.Entity.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface ITeacherSyllabusTableService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<TeacherSyllabusTable> GetActiveTeacherSyllabus();

        //Listing All (Listeleme)
        List<TeacherSyllabusTable> GetTeacherSyllabus(Expression<Func<TeacherSyllabusTable, bool>> exp);

        //Adding (Ekleme)
        void Add(TeacherSyllabusTable teacherSyllabusTable);

        //Update (Güncelleme)
        void Update(TeacherSyllabusTable teacherSyllabusTable);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        TeacherSyllabusTable GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<TeacherSyllabusTable, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<TeacherSyllabusTable, bool>> exp);
    }
}
