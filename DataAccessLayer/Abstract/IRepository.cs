using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
   public interface IRepository<T>
    {
        List<T> ListAll(); //direk listele
        T GetByID(int id); //getirmek için
        List<T> ListAll(Expression<Func<T, bool>> filter); //sartlı listelemek için
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        
      
    }
}
