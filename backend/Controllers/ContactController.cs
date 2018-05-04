using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Repository;
using backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ContactController : Controller
    {
        private ContactRepository cr = new ContactRepository();
        // GET api/contact
        [HttpGet]
        public IEnumerable<ContactModel> Get()
        {

            return cr.getContacts();
        }

        // GET api/contact/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/contact
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/contact/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/contact/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}