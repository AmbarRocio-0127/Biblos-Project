﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBiblos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiblosController : ControllerBase
    {
        // GET: api/<BiblosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BiblosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BiblosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BiblosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BiblosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
