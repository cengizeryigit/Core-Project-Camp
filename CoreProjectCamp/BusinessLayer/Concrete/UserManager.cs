using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddT(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public void UpdateT(AppUser t)
        {
            _userDal.Update(t);
        }
    }
}
