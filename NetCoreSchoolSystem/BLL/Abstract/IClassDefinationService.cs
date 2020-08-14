using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IClassDefinationService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<ClassDefination> GetActiveClDef();

        //Listing All (Listeleme)
        List<ClassDefination> GetClDef(Expression<Func<ClassDefination, bool>> exp);

        //Adding (Ekleme)
        void Add(ClassDefination classDefination);

        //Update (Güncelleme)
        void Update(ClassDefination classDefination);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        ClassDefination GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<ClassDefination, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<ClassDefination, bool>> exp);
    }
}
