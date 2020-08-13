using GroceryShopApp.Database.DatabaseContext;
using GroceryShopApp.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroceryShopApp.Repository.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly GroceryShopDb _groceryShopDb;

        public BaseRepository()
        {
            _groceryShopDb = new GroceryShopDb();
        }

        private DbSet<T> DbTable
        {
            get
            {
                return _groceryShopDb.Set<T>();
            }   

            set { }
        }

        public virtual ICollection<T> GetAll()
        {
            return DbTable.ToList();
        }

        public virtual T GetById(int? id)
        {
            return DbTable.Find(id);
        }

        public virtual bool Add(T entity)
        {
            DbTable.Add(entity);
            return _groceryShopDb.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            _groceryShopDb.Entry(entity).State = EntityState.Modified;
            return _groceryShopDb.SaveChanges() > 0;
        }

        public virtual bool Remove(T entity)
        {
            DbTable.Remove(entity);
            return _groceryShopDb.SaveChanges() > 0;
        }
    }
}
