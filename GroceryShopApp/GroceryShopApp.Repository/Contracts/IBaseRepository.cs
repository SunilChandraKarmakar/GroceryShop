using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Repository.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        ICollection<T> GetAll();
        T GetById(int? id);
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
    }
}
