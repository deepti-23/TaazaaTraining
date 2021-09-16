using System;
using Collection_practice2.Models;
using Collection_practice2.EmployeeList;
using System.Collections.Generic;
namespace Collection_practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____________WELCOME TO TAAZAA TRAINING______________");  
            Console.WriteLine("");
            Console.WriteLine("Main Menu");
            Console.WriteLine("");  
            Console.WriteLine("Enter 1 - Create Employee");
            Console.WriteLine("Enter 2 - Update Employee");
            Console.WriteLine("Enter 3 - Search Employee");
            Console.WriteLine("Enter 4 - Remove Employee");
            Console.WriteLine("Enter 5 - Exit");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: Console.WriteLine("CREATE EMPLOYEE");
                        break;  
                case 2: Console.WriteLine("UPDATE EMPLOYEE");
                        break;  
                case 3: Console.WriteLine("SEARCH EMPLOYEE");
                        break;  
                case 4: Console.WriteLine("REMOVE EMPLOYEE"); 
                        break; 
                default: Console.WriteLine("Exit");
                break;

          }  
            /* EmployeesList employeesList=new EmployeesList();
            Employee employee=new Employee();
            employee.Id=100;
            employee.Name="Deepti";
            employeesList.createEmployee(employee);


            Employee employee1=new Employee();
            employee1.Id=101;
            employee1.Name="Deepti Bansal";
            employeesList.createEmployee(employee1);
            

            /* int temp=employeesList.createEmployee(employee);
            if(temp==1)
            {
                System.Console.WriteLine("Added Successfully");
            } */
            
            /* List<Employee> employees= employeesList.DisplayList();
            int count=employees.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(employees[i].Id+" "+employees[i].Name);
            }
            int targetID=100;
            Employee obj=employeesList.search(targetID);
            Console.WriteLine(obj.Id+" "+obj.Name); */
        } 
    }
}
