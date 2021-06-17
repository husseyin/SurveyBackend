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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IEnumerable<Company> GetAll()
        {
            return _companyDal.GetAll();
        }

        //public void Add(Company company)
        //{
        //    _companyDal.Add(company);
        //}

        //public void Delete(Company company)
        //{
        //    _companyDal.Delete(company);
        //}

        //public void Update(Company company)
        //{
        //    _companyDal.Update(company);
        //}
    }
}
