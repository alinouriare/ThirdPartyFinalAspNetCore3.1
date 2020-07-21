using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IContactRepository contact;

        public ValuesController(IContactRepository contact)
        {
            this.contact = contact;
        }
        // GET api/values
        [HttpGet]
      //[Authorize]
        [Authorize(Roles = "role1")]
        public ActionResult<List<Contact>> Get()
        {
            var result= contact.GetContacts();

            return Ok(result); 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    
    }
}
