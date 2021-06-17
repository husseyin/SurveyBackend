using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();
        //void Add(Company company);
        //void Delete(Company company);
        //void Update(Company company);
    }
}
