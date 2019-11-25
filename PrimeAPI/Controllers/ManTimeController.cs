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
    public class ManTimeController : ControllerBase
    {
        [Route("{noOfHours}/{noOfMen}")]
        public string GetManHours(int noOfHours, int noOfMen)
        {
            ManTimeService manTimeService = new ManTimeService();
            return manTimeService.CalculateManHours(noOfMen, noOfHours).ToString();
        }
    }
}
