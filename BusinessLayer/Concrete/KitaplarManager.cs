using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KitaplarManager : IKitaplarService
    {
        IKitaplarDal _kitaplarDal;

        public KitaplarManager(IKitaplarDal kitaplarDal)
        {
            _kitaplarDal = kitaplarDal;
        }

        public void AddKitap(Kitaplar kitaplar)
        {
            _kitaplarDal.Insert(kitaplar);
        }

        public void DeleteKitap(Kitaplar kitaplar)
        {
            _kitaplarDal.Delete(kitaplar);
        }

        public Kitaplar GetByID(int id)
        {

            return _kitaplarDal.GetByID(id);
        }

        public List<Kitaplar> GetList()
        {
            return _kitaplarDal.ListAll();
        }

        public List<Kitaplar> ListAll(Expression<Func<Kitaplar, bool>> filter)
        {
            return _kitaplarDal.ListAll();
        }

        public void UpdateKitap(Kitaplar kitaplar)
        {
            _kitaplarDal.Update(kitaplar);
        }

        //    public void DeleteKitap(int id)
        //    {
        //        return _kitaplarDal.();        }
        //}
    }
}