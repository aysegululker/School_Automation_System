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
    public class AbsenteeismRepository : IAbsenteeismService
    {
        private readonly AppDbContext context;

        public AbsenteeismRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Absenteeism absenteeism)
        {
            context.Absenteeisms.Add(absenteeism);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Absenteeism, bool>> exp)
        {
            return context.Absenteeisms.Any(exp);
        }

        public List<Absenteeism> GetAbsenteeism(Expression<Func<Absenteeism, bool>> exp)
        {
            return context.Absenteeisms.Where(exp).ToList();
        }

        public List<Absenteeism> GetActiveAbsenteeism()
        {
            return context.Absenteeisms.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Absenteeism GetById(Guid id)
        {
            return context.Absenteeisms.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Guid id)
        {
            Absenteeism absenteeism = GetById(id);
            absenteeism.Status = DAL.Entity.Enum.Status.Deleted;
            Update(absenteeism);
        }

        public void RemoveAll(Expression<Func<Absenteeism, bool>> exp)
        {
            foreach (var item in GetAbsenteeism(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(Absenteeism absenteeism)
        {
            context.Entry(absenteeism).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
