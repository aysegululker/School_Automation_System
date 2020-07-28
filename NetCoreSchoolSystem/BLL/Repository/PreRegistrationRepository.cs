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
    public class PreRegistrationRepository : IPreRegistrationService
    {
        private readonly AppDbContext context;

        public PreRegistrationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(PreRegistration preRegistration)
        {
            context.PreRegistrations.Add(preRegistration);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<PreRegistration, bool>> exp)
        {
            return context.PreRegistrations.Any(exp);
        }

        public List<PreRegistration> GetActiveRegis()
        {
            return context.PreRegistrations.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public PreRegistration GetById(Guid id)
        {
            return context.PreRegistrations.FirstOrDefault(x => x.ID == id);
        }

        public List<PreRegistration> GetPreRegistration(Expression<Func<PreRegistration, bool>> exp)
        {
            return context.PreRegistrations.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            PreRegistration preRegistration = GetById(id);
            preRegistration.Status = DAL.Entity.Enum.Status.Deleted;
            Update(preRegistration);
        }

        public void RemoveAll(Expression<Func<PreRegistration, bool>> exp)
        {
            foreach (var item in GetPreRegistration(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(PreRegistration preRegistration)
        {
            context.Entry(preRegistration).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
