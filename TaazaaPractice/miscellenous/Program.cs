using System;
using miscellenous.IT;


namespace miscellenous
{
    class Program
    {
        static void Main()
        {
           var Mohan =new Taazaa(101,1000);
           var Sachin =new Taazaa(102,5000);
           var Deepti=new Taazaa(103,10000);

           var Mohansalary =Mohan.EmployeeSalary();   
           Console.WriteLine(Mohansalary);

           var Deeptisalary =Deepti.EmployeeSalary();   
           Console.WriteLine(Deeptisalary);

           var Cafe=Taazaa.CoffeeHouse();
           Console.WriteLine(Cafe);

           Console.WriteLine(Taazaa.CoffeeHouse());
        }
    }
}
