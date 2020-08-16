using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IStudentService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<Student> GetActiveStudent();

        //Listing All (Listeleme)
        List<Student> GetStudent(Expression<Func<Student, bool>> exp);

        List<Student> GetSyllabusStudent();

        //Adding (Ekleme)
        void Add(Student student);

        //Update (Güncelleme)
        void Update(Student student);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        Student GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<Student, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<Student, bool>> exp);

    }
}
