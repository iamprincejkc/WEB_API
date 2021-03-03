using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Dap.Models;
using WebApi_Dap.Repository;

namespace WebApi_Dap.Controllers
{
    public class TestAPIController : ApiController
    {
        // GET: api/TestAPI
        public IEnumerable<TestClass> Get()
        {
            TestRepository testrepo = new TestRepository();
            return testrepo.GetAll();
        }

        // GET: api/TestAPI/5
        public TestClass Get(int id)
        {
            TestRepository testrepo = new TestRepository();
            return testrepo.GetAll().Find(e => e.id == id);
        }

        // POST: api/TestAPI
        public void Post([FromBody]TestClass testClass)
        {
            TestRepository testrepo = new TestRepository();
            testrepo.Add(testClass);
        }

        // PUT: api/TestAPI/5
        public void Put([FromBody]TestClass testClass)
        {
            TestRepository testrepo = new TestRepository();
            testrepo.Update(testClass);
        }

        // DELETE: api/TestAPI/5
        public void Delete(int id)
        {
            TestRepository testrepo = new TestRepository();
            testrepo.Delete(id);
        }
    }
}
