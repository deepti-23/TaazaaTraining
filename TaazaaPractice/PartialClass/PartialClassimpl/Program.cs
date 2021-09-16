using System;
using PartialClassimpl;

namespace PartialClassimpl
{
    class Program
    {
        public static void Main()
        {
            person Person=new person(101);
            int temp=Person.getId();
            Console.WriteLine(temp);
        }
    }
}
