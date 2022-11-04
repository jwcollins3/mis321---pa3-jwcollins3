using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Interfaces;
using Microsoft.AspNetCore.Cors;
using api.Database;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        // GET: api/Driver
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Driver> Get()
        {
            IGetAllDrivers readObject = new ReadDriverData();
            return readObject.GetAllDrivers();

            // return readObject.GetAllDrivers();
        }

        // GET: api/Driver/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public void Get(int Id)//id
        {
            
        }

        // POST: api/Driver
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Driver value)
        {
            ISaveDriver insertObject = new SaveDriver();
            insertObject.InsertDriver(value);
        }

        // PUT: api/Driver/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put([FromBody] Driver value)
        {
            IUpdateDriver updateObject = new UpdateDriver();
            updateObject.UpdateDriverRating(value);
            // Console.WriteLine(id);
            // Console.WriteLine(value.Rating);
        }

        // DELETE: api/Driver/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
