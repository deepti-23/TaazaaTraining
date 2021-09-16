using System;
using selfanalyze.It;

namespace selfanalyze
{
    class Program
    {
        static void Main()
        {
           var Deepti=new Taazaa(103,7000);
           var Nikhil =new Taazaa(1002,6000);
           var Geetika =new Taazaa(104,4000);
           var Ganesh=new Taazaa(106,5000);

           var NikhilSalary =Nikhil.EmployeeSalary();   
           Console.WriteLine(NikhilSalary);

           var GaneshSalary =Ganesh.EmployeeSalary();   
           Console.WriteLine(GaneshSalary);


           var DeeptiId =Deepti.EmployeeId();   
           Console.WriteLine(DeeptiId);

           var Cafe=Taazaa.CoffeeHouse();
           Console.WriteLine(Cafe);

           Console.WriteLine(Taazaa.CoffeeHouse());
        }
    }
}
