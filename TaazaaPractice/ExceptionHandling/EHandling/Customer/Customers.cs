using System;
namespace EHandling.Customer
{
    // Exception Class in C# is a base class in Exception Handling which can handle all the exceptions.
    //Arithmetic Exception is a base class of Dividebyzero Exception that is why base class can handle derevied class exception 
    public class Customers
    {
        int result;
        Customers() 
        {
         result = 0;
        }
        public void Data(int num1,int num2)
        {
            try
            {
                int result=num1/num2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception Handeled",ex);
            }
            finally
            {
                Console.WriteLine(result);
            }

        }
    }
}