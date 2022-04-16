using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UserRepository : IUserDal
    {
        DataContext dc = new DataContext();

        public void AddUser(User user)
        {
            dc.Add(user);
            dc.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            dc.Remove(user);
            dc.SaveChanges();
        }

        public User GetById(int id)
        {
            return dc.Users.Find(id);
        }

        public List<User> ListAllUser()
        {
            return dc.Users.ToList();
        }

        public void UpdateUser(User user)
        {
            dc.Update(user);
            dc.SaveChanges();
        }
    }
}
