using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Manager.Base
{
    public abstract class BaseManager<T> : IBaseManager<T> where T : class
    {
        private readonly IBaseRepository<T> _iBaseRepository;

        public BaseManager(IBaseRepository<T> iBbaseRepository)
        {
            _iBaseRepository = iBbaseRepository;
        }

        public virtual ICollection<T> GetAll()
        {
            return _iBaseRepository.GetAll();
        }

        public virtual T GetById(int? id)
        {
            return _iBaseRepository.GetById(id);
        }

        public virtual bool Add(T entity)
        {
            return _iBaseRepository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _iBaseRepository.Update(entity);
        }

        public virtual bool Remove(T entity)
        {
            return _iBaseRepository.Remove(entity);
        }
    }
}
