﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagement.Data.Abstracts
{
   public interface IRepositoryBase<T> where T:class,new()
    {
        IQueryable<T> GetAll(Expression<Func<T,bool>> filter=null,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy=null,string includeProp=null);
        T Get(int id);

        T GetFirstOrDefault(Expression<Func<T,bool>> filter=null,string include=null);
        void Add(T entity);
        void Delete(T entity);

        void Update(T entity);

    }
}
