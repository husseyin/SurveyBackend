using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SurveyApi.Controllers
{
    public class CompaniesController : ApiController
    {
        ICompanyService companyService = new CompanyManager(new EfCompanyDal());

        [HttpGet]
        [ActionName("getall")]
        public IEnumerable<Company> GetAll()
        {
            return companyService.GetAll();
        }

        //[HttpPost]
        //[ActionName("add")]
        //public void Add(Company company)
        //{
        //    companyService.Add(company);
        //}

        //[HttpDelete]
        //[ActionName("delete")]
        //public void Delete(Company company)
        //{
        //    companyService.Delete(company);
        //}

        //[HttpPut]
        //[ActionName("update")]
        //public void Update(Company company)
        //{
        //    companyService.Update(company);
        //}
    }
}
