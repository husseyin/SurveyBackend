using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserAnswerService
    {
        IEnumerable<UserAnswer> GetAll();
        void Add(UserAnswer userAnswer);
        //void Delete(UserAnswer userAnswer);
        //void Update(UserAnswer userAnswer);
    }
}
