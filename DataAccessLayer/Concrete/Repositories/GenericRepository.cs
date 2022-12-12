using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        public void Delete(T p)
        {
            using var c = new Context();
            c.Remove(p);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public void Insert(T p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();

        }

        public List<T> ListAll()  //normal
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter)  //sartlı
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T p)
        {
            using var c = new Context();
            c.Update(p);
            c.SaveChanges();
        }
    }
}
