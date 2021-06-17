using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IEnumerable<User> Getall()
        {
            return _userDal.GetAll();
        }

        public string ValidUser(string username, string password)
        {
            if (_userDal.GetAll(u => u.Username == username && u.Password == password).Any())
            {
                return TokenManager.GenerateToken(username);
            }
            return "";
        }

        //public void Add(User user)
        //{
        //    _userDal.Add(user);
        //}

        //public void Delete(User user)
        //{
        //    _userDal.Delete(user);
        //}        

        //public void Update(User user)
        //{
        //    _userDal.Update(user);
        //}
    }
}
