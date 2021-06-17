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
        [ActionName("getall")]
        public IEnumerable<UserAnswer> GetAll()
        {
            return userAnswerService.GetAll();
        }

        [HttpGet]
        [ActionName("getuseranswerbyquestionid")]
        public IEnumerable<UserAnswer> GetUserAnswerByQuestionId(int questionId)
        {
            return userAnswerService.GetUserAnswerByQuestionId(questionId);
        }

        [HttpGet]
        [ActionName("getcountanswerbyquestionid")]
        public IEnumerable<object> GetCountAnswerByQuestionId(int questionId)
        {
            return userAnswerService.GetCountAnswerByQuestionId(questionId);
        }


        [HttpPost]
        [ActionName("add")]
        public void Add(UserAnswer userAnswer)
        {
            userAnswerService.Add(userAnswer);
        }

        //[HttpDelete]
        //[ActionName("delete")]
        //public void Delete(UserAnswer userAnswer)
        //{
        //    userAnswerService.Delete(userAnswer);
        //}

        //[HttpPut]
        //[ActionName("update")]
        //public void Update(UserAnswer userAnswer)
        //{
        //    userAnswerService.Update(userAnswer);
        //}
    }
}
