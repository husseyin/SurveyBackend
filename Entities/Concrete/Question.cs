﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Question
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
    }
}
