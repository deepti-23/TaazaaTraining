using System;
using Indexerp.Employeep;

namespace Indexerp
{
    class Program
    {
        static void Main()
        {
            Employee employee=new Employee();
            employee.EmpId=101;
            Console.WriteLine(employee.EmpId);
        }
    }
}
