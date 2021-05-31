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
using System.Web.Http.Cors;

namespace SurveyApi.Controllers
{
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AnswersController : ApiController
    {
        IAnswerService answerService = new AnswerManager(new EfAnswerDal());

        [HttpGet]
        [Route("getall")]
        public IEnumerable<Answer> GetAll()
        {
            return answerService.GetAll();
        }

        //[HttpPost]
        //[Route("add")]
        //public void Add(Answer answer)
        //{
        //    answerService.Add(answer);
        //}

        //[HttpDelete]
        //[Route("delete")]
        //public void Delete(Answer answer)
        //{
        //    answerService.Delete(answer);
        //}

        //[HttpPut]
        //[Route("update")]
        //public void Update(Answer answer)
        //{
        //    answerService.Update(answer);
        //}
    }
}