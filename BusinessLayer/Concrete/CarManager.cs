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
    public class CarManager : IGenericService<Car>, ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void TAdd(Car t)
        {
            _carDal.Add(t);
        }

        public void TDelete(Car t)
        {
            _carDal.Delete(t);
        }

        public List<Car> TGetAll(Car t)
        {
            return _carDal.GetAll(t);
        }

        public Car TGetById(int id)
        {
            return _carDal.GetById(id);
        }

        public void TUpdate(Car t)
        {
            _carDal.Update(t);
        }
    }
}
