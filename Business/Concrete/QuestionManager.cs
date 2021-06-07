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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IEnumerable<Question> GetAll()
        {
            return _questionDal.GetAll();
        }

        public void Add(Question question)
        {
            _questionDal.Add(question);
        }

        public void Delete(Question question)
        {
            _questionDal.Delete(question);
        }

        //public void Update(Question question)
        //{
        //    _questionDal.Update(question);
        //}
    }
}
