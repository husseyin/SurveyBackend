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

            var resultUserAnswer = userAnswerService.GetAll();

            foreach (var userAnswer in resultUserAnswer)
            {
                Console.WriteLine("SoruId: " + userAnswer.QuestionId);
                Console.WriteLine("CevapId: " + userAnswer.QuestionId);
                Console.WriteLine("Açıklama: " + userAnswer.Description);
            }

            var demo = new UserAnswer
            {
                AnswerId = 2,
                QuestionId = 3,
                Description = "demo"

            };

            userAnswerService.Add(demo);

            Console.ReadKey();
        }
    }
}
