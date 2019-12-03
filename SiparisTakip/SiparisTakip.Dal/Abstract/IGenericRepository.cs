﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract
{
    public interface IGenericRepository<T>:IDisposable where T:class
    {
        T Add(T entity);
        T Get(int id);

        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> predicate);

        bool Remove(int id);
        bool Remove(T entity);
        T Update(T entity);
        //
        //count
        //belirtilen alanın max,mix,sum

    }
}
