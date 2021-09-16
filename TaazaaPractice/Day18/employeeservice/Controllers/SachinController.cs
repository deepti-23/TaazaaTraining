using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using employeeservice.Models;
namespace employeeservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class abcController:ControllerBase
    {
        [HttpPut]
        public Employee Abc(Employee obj)
        {
            return obj;
        }
    }
}