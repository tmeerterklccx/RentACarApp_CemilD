using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class RentManager : IGenericService<Rent>, IRentService
    {
        private readonly IRentDal _rentDal;

        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }

        public void TAdd(Rent t)
        {
            _rentDal.Add(t);
        }

        public void TDelete(Rent t)
        {
            _rentDal.Delete(t);
        }

        public List<Rent> TGetAll(Rent t)
        {
            return _rentDal.GetAll(t);
        }

        public Rent TGetById(int id)
        {
            return _rentDal.GetById(id);
        }

        public void TUpdate(Rent t)
        {
            _rentDal.Update(t);
        }
    }
}
