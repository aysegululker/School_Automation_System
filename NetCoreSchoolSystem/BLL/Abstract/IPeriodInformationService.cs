using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IPeriodInformationService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<PeriodInformation> GetActivePeriodInformation();

        //Listing All (Listeleme)
        List<PeriodInformation> GetPeriodInformation(Expression<Func<PeriodInformation, bool>> exp);

        //Adding (Ekleme)
        void Add(PeriodInformation periodInformation);

        //Update (Güncelleme)
        void Update(PeriodInformation periodInformation);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        PeriodInformation GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<PeriodInformation, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<PeriodInformation, bool>> exp);
    }
}
