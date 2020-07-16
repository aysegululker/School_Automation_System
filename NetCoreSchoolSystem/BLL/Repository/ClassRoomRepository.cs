using BLL.Abstract;
using DAL.Context;
using DAL.Entity.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repository
{
    public class ClassRoomRepository : IClassRoomService
    {
        private readonly AppDbContext context;

        public ClassRoomRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(ClassRoom classRoom)
        {
            context.ClassRooms.Add(classRoom);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<ClassRoom, bool>> exp)
        {
            return context.ClassRooms.Any(exp);
        }

        public List<ClassRoom> GetActiveRoom()
        {
            return context.ClassRooms.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public ClassRoom GetById(Guid id)
        {
            return context.ClassRooms.FirstOrDefault(x => x.ID == id);
        }

        public List<ClassRoom> GetRoom(Expression<Func<ClassRoom, bool>> exp)
        {
            return context.ClassRooms.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            ClassRoom classRoom = GetById(id);
            classRoom.Status = DAL.Entity.Enum.Status.Deleted;
            Update(classRoom);
        }

        public void RemoveAll(Expression<Func<ClassRoom, bool>> exp)
        {
            foreach (var item in GetRoom(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(ClassRoom classRoom)
        {
            context.Entry(classRoom).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
