using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using employeeservice.models;
using System;
namespace employeeservice.Controllers
{

    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        [HttpGet("info")]
        public List<Employee> Empdetails()
        {
            EmployeeDetail obj =new EmployeeDetail();
            List<Employee> temp=obj.Empdetails();
            return temp;
        }
    }
}