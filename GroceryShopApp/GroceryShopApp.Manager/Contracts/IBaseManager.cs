using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Manager.Contracts
{
    public interface IBaseManager<T> where T : class
    {
        ICollection<T> GetAll();
        T GetById(int? id);
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
    }
}
