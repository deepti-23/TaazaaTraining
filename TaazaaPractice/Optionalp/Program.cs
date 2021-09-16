using System;

namespace Optionalp
{
    class Program
    {

        public static string Name_add(string str1,string str2="Deepti")
        {
            Console.WriteLine(str1+str2);
            return "";
        }
        public static void Main()
        {
            Name_add("Ms");
            Name_add("Deepti Bansal","Geetika");
        }
    }
}
