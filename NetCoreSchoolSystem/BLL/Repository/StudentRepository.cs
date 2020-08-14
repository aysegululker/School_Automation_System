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
    public class StudentRepository : IStudentService
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Student, bool>> exp)
        {
            return context.Students.Any(exp);
        }

        public List<Student> GetActiveStudent()
        {
            return context.Students.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Student GetById(Guid id)
        {
            return context.Students.FirstOrDefault(x => x.ID == id);
        }

        public List<Student> GetStudent(Expression<Func<Student, bool>> exp)
        {
            return context.Students.Where(exp).ToList();
        }

        public List<Student> GetSyllabusStudent()
        {
            AppUser appUser = new AppUser();
            var kullanici = appUser.UserName;
            return context.Students.Where(x => x.IdentificationNumber == kullanici).ToList();
        }

        public void Remove(Guid id)
        {
            Student student = GetById(id);
            student.Status = DAL.Entity.Enum.Status.Deleted;
            Update(student);
        }

        public void RemoveAll(Expression<Func<Student, bool>> exp)
        {
            foreach (var item in GetStudent(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(Student student)
        {
            context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
