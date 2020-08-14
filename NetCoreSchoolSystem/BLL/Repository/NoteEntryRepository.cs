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
    public class NoteEntryRepository : INoteEntryService
    {
        private readonly AppDbContext context;

        public NoteEntryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(NoteEntry noteEntry)
        {
            context.NoteEntries.Add(noteEntry);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<NoteEntry, bool>> exp)
        {
            return context.NoteEntries.Any(exp);
        }

        public List<NoteEntry> GetActiveNote()
        {
            return context.NoteEntries.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public NoteEntry GetById(Guid id)
        {
            return context.NoteEntries.FirstOrDefault(x => x.ID == id);
        }

        public List<NoteEntry> GetNote(Expression<Func<NoteEntry, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            NoteEntry noteEntry = GetById(id);
            noteEntry.Status = DAL.Entity.Enum.Status.Deleted;
            Update(noteEntry);
        }

        public void RemoveAll(Expression<Func<NoteEntry, bool>> exp)
        {
            foreach (var item in GetNote(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(NoteEntry noteEntry)
        {
            context.Entry(noteEntry).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
