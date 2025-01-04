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
    public class UserManager : IGenericService<User>, IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(User t)
        {
            _userDal.Add(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public List<User> TGetAll(User t)
        {
            return _userDal.GetAll(t);
        }

        public User TGetById(int id)
        {
            return _userDal.GetById(id);
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
