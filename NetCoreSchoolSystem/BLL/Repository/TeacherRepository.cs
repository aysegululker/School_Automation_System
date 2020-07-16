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
    public class TeacherRepository : ITeacherService
    {
        private readonly AppDbContext context;

        public TeacherRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Teacher, bool>> exp)
        {
            return context.Teachers.Any(exp);
        }

        public List<Teacher> GetActiveTeacher()
        {
            return context.Teachers.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Teacher GetById(Guid id)
        {
            return context.Teachers.FirstOrDefault(x => x.ID == id);
        }

        public List<Teacher> GetTeacher(Expression<Func<Teacher, bool>> exp)
        {
            return context.Teachers.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            Teacher teacher = GetById(id);
            teacher.Status = DAL.Entity.Enum.Status.Deleted;
            Update(teacher);
        }

        public void RemoveAll(Expression<Func<Teacher, bool>> exp)
        {
            foreach (var item in GetTeacher(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(Teacher teacher)
        {
            context.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
