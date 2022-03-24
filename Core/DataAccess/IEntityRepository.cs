using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess
{
    //Generic constraint T:class kısıtlaması ( referans tip olabilir)
    //IEntity olabilir veya IEntity implemente eden bir class olabilir.
    //new() lenebilir olabilir
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
