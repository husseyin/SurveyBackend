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
    public class UserAnswersController : ApiController
    {
        IUserAnswerService userAnswerService = new UserAnswerManager(new EfUserAnswerDal());

        [HttpGet]
        [Route("getall")]
        public IEnumerable<UserAnswer> GetAll()
        {
            return userAnswerService.GetAll();
        }

        [HttpPost]
        [Route("add")]
        public void Add(UserAnswer userAnswer)
        {
            userAnswerService.Add(userAnswer);
        }

        //[HttpDelete]
        //[Route("delete")]
        //public void Delete(UserAnswer userAnswer)
        //{
        //    userAnswerService.Delete(userAnswer);
        //}

        //[HttpPut]
        //[Route("update")]
        //public void Update(UserAnswer userAnswer)
        //{
        //    userAnswerService.Update(userAnswer);
        //}
    }
}
