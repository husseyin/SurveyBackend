using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Collections.Generic;
using System.Web.Http;

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