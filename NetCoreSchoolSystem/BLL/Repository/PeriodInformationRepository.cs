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
    public class PeriodInformationRepository : IPeriodInformationService
    {
        private readonly AppDbContext context;

        public PeriodInformationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(PeriodInformation periodInformation)
        {
            context.PeriodInformations.Add(periodInformation);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<PeriodInformation, bool>> exp)
        {
            return context.PeriodInformations.Any(exp);
        }

        public List<PeriodInformation> GetActivePeriodInformation()
        {
            return context.PeriodInformations.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public PeriodInformation GetById(Guid id)
        {
            return context.PeriodInformations.FirstOrDefault(x => x.ID == id);
        }

        public List<PeriodInformation> GetPeriodInformation(Expression<Func<PeriodInformation, bool>> exp)
        {
            return context.PeriodInformations.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            PeriodInformation period = GetById(id);
            period.Status = DAL.Entity.Enum.Status.Deleted;
            Update(period);
        }

        public void RemoveAll(Expression<Func<PeriodInformation, bool>> exp)
        {
            foreach (var item in GetPeriodInformation(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(PeriodInformation periodInformation)
        {
            context.Entry(periodInformation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
