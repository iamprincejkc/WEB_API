using System.Linq;
using System.Web.Http;
using WEB_API.Models;
using WEB_API.Repository;
using WEB_API.Services;

namespace WEB_API.Controllers
{
    public class TestAPIController : ApiController
    {


        TestEntities db3= new TestEntities(); //ADO ENTITY MODEL
        //DbModel db2 = new DbModel(); //SQL CONNECTION
        ITestDetails db = new TestDetails();

        [Route("api/TestApi")]
        [HttpGet]
        public IHttpActionResult GetData()
        {
            //var result = db.sp_view().ToList();
            //var result = db2.GetData().ToList();
            var result = db.GetData();

            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        //[ResponseType(typeof(model_class_name_DTO))]
        [Route("api/TestApi/{id}")]
        [HttpGet]
        public IHttpActionResult GetDataById(int id)
        {
            //var result = db3.sp_viewbyid(id).ToList();
            //var result = db2.GetDataByID(id).ToList();
            var result = db.GetDataByID(id);

            if (result==null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [Route("api/TestApi/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteDataById(int id)
        {
            //var result = db.sp_delete(id);
            //var result = db2.DeleteByID(id);
            var result = db.DeleteDataById(id);

            return Ok(result);
        }

        [Route("api/TestApi")]
        [HttpPost]
        public IHttpActionResult PostData(TestClass test)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var result = db.PostData(test);
                    return Created(Request.RequestUri + test.id.ToString(), result);
                }
                else
                {
                    return BadRequest("Error please check");
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [Route("api/TestApi")]
        [HttpPut]
        public IHttpActionResult PutData(TestClass test)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    //db.sp_update(test.id,test.fname,test.lname,test.email);
                    //db2.Update(test);
                    var result = db.PutData(test);

                    return Ok();
                }
                else
                {
                    return BadRequest("Error please check");
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }

            
        }

        [Route("api/TestAPI/search/{key}")]
        public IHttpActionResult GetSearchData(string key)
        {
            //var result = db.sp_search(key).ToList();
            //var result = db2.Search(key).ToList();
            var result = db.GetSearchData(key);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
