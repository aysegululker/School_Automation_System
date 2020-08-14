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
    public class SyllabusTableRepository : ISyllabusTableService
    {
        private readonly AppDbContext context;

        public SyllabusTableRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(SyllabusTable syllabusTable)
        {
            context.SyllabusTables.Add(syllabusTable);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<SyllabusTable, bool>> exp)
        {
            return context.SyllabusTables.Any(exp);
        }

        public List<SyllabusTable> GetActiveSyllabus()
        {
            return context.SyllabusTables.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public SyllabusTable GetById(Guid id)
        {
            return context.SyllabusTables.FirstOrDefault(x => x.ID == id);
        }

        public List<SyllabusTable> GetSyllabus(Expression<Func<SyllabusTable, bool>> exp)
        {
            return context.SyllabusTables.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            SyllabusTable syllabusTable = GetById(id);
            syllabusTable.Status = DAL.Entity.Enum.Status.Deleted;
            Update(syllabusTable);
        }

        public void RemoveAll(Expression<Func<SyllabusTable, bool>> exp)
        {
            foreach (var item in GetSyllabus(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(SyllabusTable syllabusTable)
        {
            context.Entry(syllabusTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
