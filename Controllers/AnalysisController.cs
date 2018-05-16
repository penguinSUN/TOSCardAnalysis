using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace TOSCardAnalysis.Controllers
{
    [Route("api/toscard/")]
    public class AnalysisController : Controller
    {
        private readonly IAnalsisService service;

        public AnalysisController(IAnalsisService service)
        {
            this.service = service;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("analysis")]
        public void Post([FromBody]AnalysisInputModel value)
        {
            var a = service.GetAnalsisResult(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
