using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeLibrary;

namespace PrimeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeController : ControllerBase
    {
        // GET: api/Prime/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            PrimeService primeService = new PrimeService();
            if (primeService.IsPrime(id))
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }

    }
}
