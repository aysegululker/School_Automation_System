using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IBranchService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<Branch> GetActiveBranch();

        //Listing All (Listeleme)
        List<Branch> GetBranch(Expression<Func<Branch, bool>> exp);

        //Adding (Ekleme)
        void Add(Branch branch);

        //Update (Güncelleme)
        void Update(Branch branch);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        Branch GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<Branch, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<Branch, bool>> exp);
    }
}
