using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class YayinevleriManager : IYayinevleriService
    {
        IYayinevleriDal _yayinevleriDal;

        public YayinevleriManager(IYayinevleriDal yayinevleriDal)
        {
            _yayinevleriDal = yayinevleriDal;
        }

        public void AddYayinevleri(Yayinevleri yayinevleri)
        {
            _yayinevleriDal.Insert(yayinevleri);
        }

        public void DeleteYayinevleri(Yayinevleri yayinevleri)
        {
            _yayinevleriDal.Delete(yayinevleri);
        }

        public Yayinevleri GetByID(int id)
        {
            return _yayinevleriDal.GetByID(id);
        }

        public List<Yayinevleri> GetList()
        {
            return _yayinevleriDal.ListAll();
        }

        public List<Yayinevleri> ListAll(Expression<Func<Yayinevleri, bool>> filter)
        {
            return _yayinevleriDal.ListAll();
        }

        public void UpdateYayinevleri(Yayinevleri yayinevleri)
        {
            _yayinevleriDal.Update(yayinevleri);
        }
    }
}
