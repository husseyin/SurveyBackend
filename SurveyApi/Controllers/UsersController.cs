using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SurveyApi.Controllers
{
    public class UsersController : ApiController
    {
        IUserService userService= new UserManager(new EfUserDal());

        [HttpGet]
        [ActionName("getall")]
        public IEnumerable<User> GetAll()
        {
            return userService.Getall();
        }

        [HttpGet]
        [ActionName("validuser")]
        public string ValidUser(string username, string password)
        {
            return userService.ValidUser(username, password);
        }

        //[HttpPost]
        //[ActionName("add")]
        //public void Add(User user)
        //{
        //    answerService.Add(user);
        //}

        //[HttpDelete]
        //[ActionName("delete")]
        //public void Delete(User user)
        //{
        //    answerService.Delete(user);
        //}

        //[HttpPut]
        //[ActionName("update")]
        //public void Update(User user)
        //{
        //    answerService.Update(user);
        //}
    }
}
