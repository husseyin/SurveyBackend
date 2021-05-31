﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        IEnumerable<Question> GetAll();
        //void Add(Question question);
        //void Delete(Question question);
        //void Update(Question question);
    }
}
