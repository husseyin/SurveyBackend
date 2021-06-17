using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserAnswerDal : EfEntityRepository<UserAnswer, SurveyContext>, IUserAnswerDal
    {
        public IEnumerable<UserAnswer> GetUserAnswers(Expression<Func<UserAnswer, bool>> filter = null)
        {
            using (SurveyContext context = new SurveyContext())
            {
                var result = from u in context.UserAnswers
                             join q in context.Questions
                             on u.QuestionId equals q.Id
                             join a in context.Answers
                             on u.AnswerId equals a.Id

                             select new UserAnswer
                             {
                                 Id = u.Id,
                                 QuestionId = q.Id,                                 
                                 AnswerId = a.Id,                    
                                 Description = u.Description
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public IEnumerable<object> GetCountAnswerByQuestionId(int questionId)
        {
            using (SurveyContext context = new SurveyContext())
            {
                var result = from u in context.UserAnswers
                             orderby u.AnswerId
                             group u by u.AnswerId into grp                             
                             select new { AnswerId = grp.Key, Count = grp.Where(q => q.QuestionId == questionId).Count() };

                return result.ToList();
            }            
        }
    }
}
