using api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

using System.Net.Http.Headers;
using System.Text;
using OsTicket.API;


namespace api.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()

        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get([FromUri]int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

  

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("PostTicket")]
        public IHttpActionResult PostTicket([FromUri] string Subject,string Message, string Email)
        {
            try
            {
                var remote = "2B20402C0FC549D43E562FD114D3E4D2";
                //var local = "E6D533E384251A50B5518A819BCBA021";
                var APIProxy = new APIProxy("http://support.f9portal.net", remote);
                var Ticket = new Ticket()
                {
                   
                    Email = Email.ToString(),
                    Name = Email.Split('@')[0],
                    Subject = Subject.ToString(),
                    Message = Message.ToString(),
                    IsMessageHtml = true,
                    PriorityId = 5,
                    TopicId = 10,
                };
                var result = APIProxy.SubmitTicket(Ticket);
                return Json(new { message = "Successfully created with this ticket no. "+ result, success = true });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex.Message, success = false });
            }

        }        
        public void Put(int id, [FromBody]string value)
        {


        }
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }


    
}
