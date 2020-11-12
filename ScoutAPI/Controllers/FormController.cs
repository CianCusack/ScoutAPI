using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ScoutAPI.Domain;
using ScoutAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScoutAPI.Controllers
{
    [Route("api/form")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormDomain _formDomain;

        public FormController(IFormDomain formDomain)
        {
            _formDomain = formDomain;
        }

        // GET: api/<Test>
        [HttpGet]
        public async Task<IEnumerable<IFormReturnEntity>> Get()
        {

            return await _formDomain.GetAllForms();
        }
         
        // GET api/<Test>/5
        [HttpGet("{id}")]
        public async Task<IReturnEntity> Get(int id)
        {
            IFormApi api = await _formDomain.GetFormById(id);
            if (api is null)
                return new RequestReturnEntity("No record for this ID.", 400);
            IFormReturnEntity returnEntity = new FormReturnEntity(api);
            return returnEntity;
        }

        // GET api/<Test>/5
        [HttpGet("{fromDate}/{toDate}")]
        public async Task<IEnumerable<IReturnEntity>> Get(string fromDate, string toDate)
        {
            var returnEntities = new List<IFormReturnEntity>();
            IEnumerable<IFormApi> apis = await _formDomain.GetFormsWithDates(
                DateTime.ParseExact(fromDate, "yyyyMMdd", CultureInfo.InvariantCulture),
                DateTime.ParseExact(toDate, "yyyyMMdd", CultureInfo.InvariantCulture));

            if (apis is null || !apis.Any())
                return returnEntities;
            
            foreach(var api in apis)
                returnEntities.Add(new FormReturnEntity(api));

            return returnEntities;
        }

        // POST api/<Test>
        [HttpPost]
        public async Task<IRequestReturnEntity> Post([FromBody] InputForm inputForm)
        {
            if (!ModelState.IsValid)
                return new RequestReturnEntity("Invalid Data." , 400);

            await _formDomain.AddFormRecord(inputForm);

            return new RequestReturnEntity("Successfully created new form record.", 200);
        }

        // PUT api/<Test>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Test>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
