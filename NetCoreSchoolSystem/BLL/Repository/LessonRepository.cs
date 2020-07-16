using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repository
{
    public class LessonRepository : ILessonService
    {
        private readonly AppDbContext context;

        public LessonRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Lesson lesson)
        {
            context.Lessons.Add(lesson);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Lesson, bool>> exp)
        {
            return context.Lessons.Any(exp);
        }

        public List<Lesson> GetActiveLesson()
        {
            return context.Lessons.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Lesson GetById(Guid id)
        {
            return context.Lessons.FirstOrDefault(x => x.ID == id);
        }

        public List<Lesson> GetLesson(Expression<Func<Lesson, bool>> exp)
        {
            return context.Lessons.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            Lesson lesson = GetById(id);
            lesson.Status = DAL.Entity.Enum.Status.Deleted;
            Update(lesson);
        }

        public void RemoveAll(Expression<Func<Lesson, bool>> exp)
        {
            foreach (var item in GetLesson(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(Lesson lesson)
        {
            context.Entry(lesson).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
