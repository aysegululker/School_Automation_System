using BLL.Abstract;
using DAL.Context;
using DAL.Entity.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repository
{
    public class RoomLessonTeacherRepository : IRoomLessonTeacherService
    {
        private readonly AppDbContext context;

        public RoomLessonTeacherRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(RoomLessonTeacher roomLessonTeacher)
        {
            context.RoomLessonTeachers.Add(roomLessonTeacher);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<RoomLessonTeacher, bool>> exp)
        {
            return context.RoomLessonTeachers.Any(exp);
        }

        public List<RoomLessonTeacher> GetActiveRoomLessonTeacher()
        {
            return context.RoomLessonTeachers.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public RoomLessonTeacher GetById(Guid id)
        {
            return context.RoomLessonTeachers.FirstOrDefault(x => x.ID == id);
        }

        public List<RoomLessonTeacher> GetRoomLessonTeacher(Expression<Func<RoomLessonTeacher, bool>> exp)
        {
            return context.RoomLessonTeachers.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            RoomLessonTeacher roomLessonTeacher = GetById(id);
            roomLessonTeacher.Status = DAL.Entity.Enum.Status.Deleted;
            Update(roomLessonTeacher);
        }

        public void RemoveAll(Expression<Func<RoomLessonTeacher, bool>> exp)
        {
            foreach (var item in GetRoomLessonTeacher(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(RoomLessonTeacher roomLessonTeacher)
        {
            context.Entry(roomLessonTeacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
