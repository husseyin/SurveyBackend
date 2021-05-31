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
    public class QuestionsController : ApiController
    {
        IQuestionService questionService = new QuestionManager(new EfQuestionDal());

        [HttpGet]
        [Route("getall")]
        public IEnumerable<Question> GetAll()
        {
            return questionService.GetAll();
        }

        //[HttpPost]
        //[Route("add")]
        //public void Add(Question question)
        //{
        //    questionService.Add(question);            
        //}

        //[HttpDelete]
        //[Route("delete")]
        //public void Delete(Question question)
        //{
        //    questionService.Delete(question);
        //}

        //[HttpPut]
        //[Route("update")]
        //public void Update(Question question)
        //{
        //    questionService.Update(question);
        //}
    }
}
