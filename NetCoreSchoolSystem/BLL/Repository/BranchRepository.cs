using BLL.Abstract;
using DAL.Context;
using DAL.Entity.OneToMany;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repository
{
    public class BranchRepository : IBranchService
    {
        private readonly AppDbContext context;

        public BranchRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Branch branch)
        {
            context.Branches.Add(branch);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Branch, bool>> exp)
        {
            return context.Branches.Any(exp);
        }

        public List<Branch> GetActiveBranch()
        {
            return context.Branches.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public List<Branch> GetBranch(Expression<Func<Branch, bool>> exp)
        {
            return context.Branches.Where(exp).ToList();
        }

        public Branch GetById(Guid id)
        {
            return context.Branches.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Guid id)
        {
            Branch branch = GetById(id);
            branch.Status = DAL.Entity.Enum.Status.Deleted;
            Update(branch);
        }

        public void RemoveAll(Expression<Func<Branch, bool>> exp)
        {
            foreach (var item in GetBranch(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(Branch branch)
        {
            context.Entry(branch).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
