using System;
namespace advancetraining.Miscellenous
{
    public class IT
    {
        static IT()         //Static Constructor
        {
            Console.WriteLine("I am Static constructor");
        }
        public static string CompanyAddress()
        {
            return "Taaza Noida";
        }
    }

}