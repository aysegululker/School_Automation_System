using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface ISyllabusTableService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<SyllabusTable> GetActiveSyllabus();

        //Listing All (Listeleme)
        List<SyllabusTable> GetSyllabus(Expression<Func<SyllabusTable, bool>> exp);

        //Adding (Ekleme)
        void Add(SyllabusTable syllabusTable);

        //Update (Güncelleme)
        void Update(SyllabusTable syllabusTable);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        SyllabusTable GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<SyllabusTable, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<SyllabusTable, bool>> exp);
    }
}
