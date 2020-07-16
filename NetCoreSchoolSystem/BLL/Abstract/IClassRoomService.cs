using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IClassRoomService
    {
        //Active Listing (Aktif olanları Listeleme)
        List<ClassRoom> GetActiveRoom();

        //Listing All (Listeleme)
        List<ClassRoom> GetRoom(Expression<Func<ClassRoom, bool>> exp);

        //Adding (Ekleme)
        void Add(ClassRoom classRoom);

        //Update (Güncelleme)
        void Update(ClassRoom classRoom);

        //Delete (Silme)
        void Remove(Guid id);

        //Get (Getirme)
        ClassRoom GetById(Guid id);

        //All Remove (Toplu Silme)
        void RemoveAll(Expression<Func<ClassRoom, bool>> exp);

        //Condition (Şart)
        bool Any(Expression<Func<ClassRoom, bool>> exp);
    }
}
