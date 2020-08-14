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
    public class ClassDefinationRepository : IClassDefinationService
    {
        private readonly AppDbContext context;

        public ClassDefinationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(ClassDefination classDefination)
        {
            context.ClassDefinations.Add(classDefination);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<ClassDefination, bool>> exp)
        {
            return context.ClassDefinations.Any(exp);
        }

        public List<ClassDefination> GetActiveClDef()
        {
            return context.ClassDefinations.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public ClassDefination GetById(Guid id)
        {
            return context.ClassDefinations.FirstOrDefault(x => x.ID == id);
        }

        public List<ClassDefination> GetClDef(Expression<Func<ClassDefination, bool>> exp)
        {
            return context.ClassDefinations.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            ClassDefination classDefination = GetById(id);
            classDefination.Status = DAL.Entity.Enum.Status.Deleted;
            Update(classDefination);
        }

        public void RemoveAll(Expression<Func<ClassDefination, bool>> exp)
        {
            foreach (var item in GetClDef(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(ClassDefination classDefination)
        {
            context.Entry(classDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
