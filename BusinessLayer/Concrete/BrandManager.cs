using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BrandManager : IGenericService<Brand>, IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void TAdd(Brand t)
        {
            _brandDal.Add(t);
        }

        public void TDelete(Brand t)
        {
            _brandDal.Delete(t);
        }

        public List<Brand> TGetAll(Brand t)
        {
            return _brandDal.GetAll(t);
        }

        public Brand TGetById(int id)
        {
           return _brandDal.GetById(id);
        }

        public void TUpdate(Brand t)
        {
            _brandDal.Update(t);
        }
    }
}
