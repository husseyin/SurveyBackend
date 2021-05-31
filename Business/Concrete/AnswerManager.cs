using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;
        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public IEnumerable<Answer> GetAll()
        {
            return _answerDal.GetAll();
        }

        //public void Add(Answer answer)
        //{
        //    _answerDal.Add(answer);
        //}

        //public void Delete(Answer answer)
        //{
        //    _answerDal.Delete(answer);
        //}

        //public void Update(Answer answer)
        //{
        //    _answerDal.Update(answer);
        //}
    }
}
