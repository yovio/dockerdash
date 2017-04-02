using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DockerDash.Controllers.Api.Docker
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/docker/host")]
    public class HostController : Controller
    {
        private DockerService _dockerService;

        public HostController(DockerService dockerService)
        {
            _dockerService = dockerService;
        }
        // GET: api/Host
        [HttpGet]
        public HostModel Get()
        {
            var task = _dockerService.GetHostInfo();
            if (task.Wait(10000))
                return task.Result;
            else
                return null;
        }

        // GET: api/Host/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Host
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Host/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
