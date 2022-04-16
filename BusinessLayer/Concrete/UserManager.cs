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
        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GetList()
        {
            return _userDal.ListAllUser();
        }

        public void UserAdd(User user)
        {
            _userDal.AddUser(user);
        }

        public void UserDelete(User user)
        {
            _userDal.DeleteUser(user);
        }

        public void UserUpdate(User user)
        {
            _userDal.UpdateUser(user);
        }
    }
}
