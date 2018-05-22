﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    

namespace DomainModel
{
    public class GenericRepository<T> : IGenericRepository<T>
    where T : class
    {

        private DataContext _entities;
        public GenericRepository()
        {
            _entities = new DataContext();
            _entities.Database.Initialize(true);
        }

        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {

            //if (entity is Client)
            ////{
            ////    using (DataContext dc = new DataContext())
            ////    {
            ////        Client cl = new Client();


            ////        var orders = dc.orders.Where(item => item.idClient == ((Client)entity).idClient).ToList();
            ////       // foreach(var p in orders)


            ////    }

            ////}


            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
