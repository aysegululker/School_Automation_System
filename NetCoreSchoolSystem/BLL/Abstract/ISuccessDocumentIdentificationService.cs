using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface ISuccessDocumentIdentificationService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<SuccessDocumentIdentification> GetActiveSucDocument();

        //Listing All (Listeleme)
        List<SuccessDocumentIdentification> GetSucDocument(Expression<Func<SuccessDocumentIdentification, bool>> exp);

        //Adding (Ekleme)
        void Add(SuccessDocumentIdentification successDocumentIdentification);

        //Update (Güncelleme)
        void Update(SuccessDocumentIdentification successDocumentIdentification);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        SuccessDocumentIdentification GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<SuccessDocumentIdentification, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<SuccessDocumentIdentification, bool>> exp);
    }
}
