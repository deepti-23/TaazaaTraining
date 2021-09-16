using System.Collections.Generic;
using employeeservice.models;

namespace employeeservice.models
{
    public class EmployeeDetail
    {
        public List<Employee> Empdetails()
        {
            List<Employee> obj=new List<Employee>();
            obj.Add(new Employee{
                phno=798,
                name="Deepti"
            });

            return obj;
        }
    }
}