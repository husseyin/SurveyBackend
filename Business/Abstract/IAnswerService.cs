using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IEnumerable<Answer> GetAll();
        //void Add(Answer answer);
        //void Delete(Answer answer);
        //void Update(Answer answer);
    }
}
