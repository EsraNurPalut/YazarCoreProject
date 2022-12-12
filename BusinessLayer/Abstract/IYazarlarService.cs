using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IYazarlarService
    {
        List<Yazarlar> GetList();
        void AddYazar(Yazarlar yazarlar);
        void UpdateYazar(Yazarlar yazarlar);
        void DeleteYazar(Yazarlar yazarlar);
        Yazarlar GetByID(int id);
        List<Yazarlar> ListAll(Expression<Func<Yazarlar, bool>> filter);
    }
}
