using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Generic Constraint 
        // where T:class means T must be a reference type not a class!!! 
        //In "where T:class, IEntity" IEntity means T can be IEntity or an object which implements IEntity (before adding new()) 
        // In "where T:class, IEntity, new()" new() means T must be newable (not abstract) 

        List<T> GetAll(Expression<Func<T,bool>>filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
