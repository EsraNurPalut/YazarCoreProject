using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IYayinevleriService
    {
        List<Yayinevleri> GetList();
        void AddYayinevleri(Yayinevleri yayinevleri);
        void UpdateYayinevleri(Yayinevleri yayinevleri);
        void DeleteYayinevleri(Yayinevleri yayinevleri);
        Yayinevleri GetByID(int id);
        List<Yayinevleri> ListAll(Expression<Func<Yayinevleri, bool>> filter);
    }

}
