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
    public class SuccessDocumentIdentificationRepository : ISuccessDocumentIdentificationService
    {
        private readonly AppDbContext context;

        public SuccessDocumentIdentificationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(SuccessDocumentIdentification successDocumentIdentification)
        {
            context.SuccessDocumentIdentifications.Add(successDocumentIdentification);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<SuccessDocumentIdentification, bool>> exp)
        {
            return context.SuccessDocumentIdentifications.Any(exp);
        }

        public List<SuccessDocumentIdentification> GetActiveSucDocument()
        {
            return context.SuccessDocumentIdentifications.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public SuccessDocumentIdentification GetById(Guid id)
        {
            return context.SuccessDocumentIdentifications.FirstOrDefault(x => x.ID == id);
        }

        public List<SuccessDocumentIdentification> GetSucDocument(Expression<Func<SuccessDocumentIdentification, bool>> exp)
        {
            return context.SuccessDocumentIdentifications.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            SuccessDocumentIdentification successDocumentIdentification = GetById(id);
            successDocumentIdentification.Status = DAL.Entity.Enum.Status.Deleted;
            Update(successDocumentIdentification);
        }

        public void RemoveAll(Expression<Func<SuccessDocumentIdentification, bool>> exp)
        {
            foreach (var item in GetSucDocument(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(SuccessDocumentIdentification successDocumentIdentification)
        {
            context.Entry(successDocumentIdentification).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
