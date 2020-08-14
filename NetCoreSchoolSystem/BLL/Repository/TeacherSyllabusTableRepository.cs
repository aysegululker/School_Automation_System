using BLL.Abstract;
using DAL.Context;
using DAL.Entity.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repository
{
    public class TeacherSyllabusTableRepository : ITeacherSyllabusTableService
    {
        private readonly AppDbContext context;

        public TeacherSyllabusTableRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(TeacherSyllabusTable teacherSyllabusTable)
        {
            context.TeacherSyllabusTables.Add(teacherSyllabusTable);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<TeacherSyllabusTable, bool>> exp)
        {
            return context.TeacherSyllabusTables.Any(exp);
        }

        public List<TeacherSyllabusTable> GetActiveTeacherSyllabus()
        {
            return context.TeacherSyllabusTables.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public TeacherSyllabusTable GetById(Guid id)
        {
            return context.TeacherSyllabusTables.FirstOrDefault(x => x.ID == id);
        }

        public List<TeacherSyllabusTable> GetTeacherSyllabus(Expression<Func<TeacherSyllabusTable, bool>> exp)
        {
            return context.TeacherSyllabusTables.Where(exp).ToList();
        }

        public void Remove(Guid id)
        {
            TeacherSyllabusTable syllabusTable = GetById(id);
            syllabusTable.Status = DAL.Entity.Enum.Status.Deleted;
            Update(syllabusTable);
        }

        public void RemoveAll(Expression<Func<TeacherSyllabusTable, bool>> exp)
        {
            foreach (var item in GetTeacherSyllabus(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(TeacherSyllabusTable teacherSyllabusTable)
        {
            context.Entry(teacherSyllabusTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
