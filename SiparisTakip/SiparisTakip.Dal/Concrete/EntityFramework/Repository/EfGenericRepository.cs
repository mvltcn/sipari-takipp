﻿using SiparisTakip.Dal.Abstract;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public SiparisTakipContext context;

        public EfGenericRepository()
        {
            context = new SiparisTakipContext();
        }

        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {
                context.Dispose();
            }
        }
        public T Get(int id)
        {
            var entity = context.Set<T>().Find(id);
            context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return entity;
        }

        public List<T> GetAll()
        {
            return context.Set<T>().AsNoTracking().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public bool Remove(int id)
        {
            return Remove(Get(id));
        }

        public bool Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges() > 0;
        }

        public T Update(T entity)
        {
            context.Set<T>().AddOrUpdate(entity);
            context.SaveChanges();
            return entity;
        }

        //public abstract void Topla();
    }
}
