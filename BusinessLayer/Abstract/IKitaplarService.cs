using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IKitaplarService
    {
        List<Kitaplar> GetList();
        void AddKitap(Kitaplar kitaplar);
        void UpdateKitap(Kitaplar kitaplar);
        void DeleteKitap(Kitaplar kitaplar);
        Kitaplar GetByID(int id);
        List<Kitaplar> ListAll(Expression<Func<Kitaplar, bool>> filter);

    }
}
