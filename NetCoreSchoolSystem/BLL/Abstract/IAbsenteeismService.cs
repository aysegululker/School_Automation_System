using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IAbsenteeismService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<Absenteeism> GetActiveAbsenteeism();

        //Listing All (Listeleme)
        List<Absenteeism> GetAbsenteeism(Expression<Func<Absenteeism, bool>> exp);

        //Adding (Ekleme)
        void Add(Absenteeism absenteeism);

        //Update (Güncelleme)
        void Update(Absenteeism absenteeism);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        Absenteeism GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<Absenteeism, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<Absenteeism, bool>> exp);
    }
}
