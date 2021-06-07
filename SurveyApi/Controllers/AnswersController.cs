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
        [ActionName("getall")]
        public IEnumerable<Answer> GetAll()
        {
            return answerService.GetAll();
        }

        //[HttpPost]
        //[ActionName("add")]
        //public void Add(Answer answer)
        //{
        //    answerService.Add(answer);
        //}

        //[HttpDelete]
        //[ActionName("delete")]
        //public void Delete(Answer answer)
        //{
        //    answerService.Delete(answer);
        //}

        //[HttpPut]
        //[ActionName("update")]
        //public void Update(Answer answer)
        //{
        //    answerService.Update(answer);
        //}
    }
}