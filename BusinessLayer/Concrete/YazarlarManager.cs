using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class YazarlarManager:IYazarlarService
    {
         IYazarlarDal _yazarlarDal;

        public YazarlarManager(IYazarlarDal yazarlarDal)
        {
            _yazarlarDal = yazarlarDal;
        }

        public void AddYazar(Yazarlar yazarlar)
        {
            _yazarlarDal.Insert(yazarlar);
        }

        public void DeleteYazar(Yazarlar yazarlar)
        {
            _yazarlarDal.Delete(yazarlar);
        }

        public Yazarlar GetByID(int id)
        {
            return _yazarlarDal.GetByID(id);
        }

        public List<Yazarlar> GetList()
        {
            return _yazarlarDal.ListAll();
        }

        public List<Yazarlar> ListAll(Expression<Func<Yazarlar, bool>> filter)
        {
            return _yazarlarDal.ListAll();
        }

        public void UpdateYazar(Yazarlar yazarlar)
        {
            _yazarlarDal.Update(yazarlar);
        }
    }
}
