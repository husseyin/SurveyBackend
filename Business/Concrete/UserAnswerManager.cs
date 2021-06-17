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
    public class UserAnswerManager : IUserAnswerService
    {
        IUserAnswerDal _userAnswerDal;

        public UserAnswerManager(IUserAnswerDal userAnswerDal)
        {
            _userAnswerDal = userAnswerDal;
        }

        public IEnumerable<UserAnswer> GetAll()
        {
            return _userAnswerDal.GetAll();
        }

        public IEnumerable<UserAnswer> GetUserAnswerByQuestionId(int questionId)
        {
            return _userAnswerDal.GetAll(q => q.QuestionId == questionId);
        }

        public IEnumerable<object> GetCountAnswerByQuestionId(int questionId)
        {
            return _userAnswerDal.GetCountAnswerByQuestionId(questionId);
        }

        public void Add(UserAnswer userAnswer)
        {
            _userAnswerDal.Add(userAnswer);
        }

        //public void Delete(UserAnswer userAnswer)
        //{
        //    _userAnswerDal.Delete(userAnswer);
        //}        

        //public void Update(UserAnswer userAnswer)
        //{
        //    _userAnswerDal.Update(userAnswer);
        //}
    }
}
