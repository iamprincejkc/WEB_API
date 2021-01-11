using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    public class TestAPIController : ApiController
    {
        TestEntities db = new TestEntities();

        public IHttpActionResult GetData()
        {
            var result = db.sp_view().ToList();
            if(result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        public IHttpActionResult GetDataById(int id)
        {
            var result = db.sp_viewbyid(id).ToList();
            if(result==null)
            {
                return NotFound();
            }


            return Ok(result);
        }

        public IHttpActionResult DeleteDataById(int id)
        {
            db.sp_delete(id);
            return Ok();
        }

        public IHttpActionResult PostData([FromBody] string message, TestClass test)
        {
            if(test==null)
            {
                return NotFound();
            }

            ObjectParameter output = new ObjectParameter("result", typeof(int));
            var result = db.sp_add(test.fname, test.lname, test.email,output);

            

            return Ok(output.Value);
        }
        public IHttpActionResult PutData(TestClass test)
        {
            if(test==null)
            {
                return NotFound();
            }

            db.sp_update(test.id,test.fname,test.lname,test.email);

            return Ok();
        }
        [Route("api/search/{key}")]
        public IHttpActionResult GetSearchData(string key)
        {
            var result = db.sp_search(key).ToList();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
