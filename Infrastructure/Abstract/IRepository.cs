using Infrastructure.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstract
{
    public interface IRepository<T>
    {


        //List<T> GetAll(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> orderby = null, Sorted sorted = Sorted.ASC, bool NoTracking = false, params string[] includelist);


        //T Get(Expression<Func<T, bool>> filter, bool NoTracking = false, params string[] includelist);

        //int GetCount(Expression<Func<T, bool>> filter, params string[] includelist);


        // T GetById(int Id); 

        //T Insert(T entity);

        //T Delete(T entity);


        // T DeleteById(int Id);

        //T Update(T entity);

    }
}
