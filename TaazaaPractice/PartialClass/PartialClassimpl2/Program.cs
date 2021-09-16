using System;
using PartialClassimpl2.Employeep;

namespace PartialClassimpl2
{
    class Program
    {
        static void Main()
        {
            Employee employee=new Employee("Hi! Deepti");
            string temp=employee.getename();
            Console.WriteLine(temp);
        }
    }
}
