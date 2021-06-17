using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserAnswerService userAnswerService = new UserAnswerManager(new EfUserAnswerDal());


            var result = from u in userAnswerService.GetAll()
                         orderby u.AnswerId
                         group u by u.AnswerId into g
                         select new { AnswerId = g.Key, Count = g.Where(q => q.QuestionId == 87).Count() };

            foreach (var item in result)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
