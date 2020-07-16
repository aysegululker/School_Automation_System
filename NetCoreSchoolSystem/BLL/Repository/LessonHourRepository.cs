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
    public class LessonHourRepository : ILessonHourService
    {
        private readonly AppDbContext context;

        public LessonHourRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(LessonHour lessonHour)
        {
            context.LessonHours.Add(lessonHour);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<LessonHour, bool>> exp)
        {
            return context.LessonHours.Any(exp);
        }

        public List<LessonHour> GetActiveHour()
        {
            return context.LessonHours.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public LessonHour GetById(Guid id)
        {
            return context.LessonHours.FirstOrDefault(x => x.ID == id);
        }

        public List<LessonHour> GetHour(Expression<Func<LessonHour, bool>> exp)
        {
            return context.LessonHours.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            LessonHour lessonHour = GetById(id);
            lessonHour.Status = DAL.Entity.Enum.Status.Deleted;
            Update(lessonHour);
        }

        public void RemoveAll(Expression<Func<LessonHour, bool>> exp)
        {
            foreach (var item in GetHour(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(LessonHour lessonHour)
        {
            context.Entry(lessonHour).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
    
}
