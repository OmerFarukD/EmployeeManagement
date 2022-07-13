using EmployeeManagement.Data.Abstracts;
using EmployeeManagement.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagement.Data.Concretes
{
    public class EfRepository<T> : IRepositoryBase<T> where T :class,new()
    {
        private readonly EmployeeManagementContext _context;
        internal DbSet<T> dbSet; 
        public EfRepository(EmployeeManagementContext context)
        {
            _context = context;
            this.dbSet = context.Set<T>();
        }
        /// <summary>
        /// T tipindeki varlığı ekler.
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
        /// <summary>
        /// T tipindeki varlığı siler.
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProp = null)
        {
            IQueryable<T> query = dbSet;
            if (filter!=null)
            {
                query = query.Where(filter);
            }
            if (includeProp != null)
            {
                foreach (var item in includeProp.Split(new char[] {',' },StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            if (orderBy!=null)
            {
                query = orderBy(query);
            }
            return query;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string include = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                foreach (var item in include.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault();
        }
        /// <summary>
        /// T tipindeki varlığı günceller.
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
