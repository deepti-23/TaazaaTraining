                                                  // Copy Constructor 
using System;

namespace Hello_world
{
    class Person
    {
        public string resume{get;set;}//instance variable
        public Person(string r) // parameterize constructor
        {
            resume=r;
        }
        public Person() // default constructor
        {

        }
        public Person(Person obj) // copy constructor
        {
            this.resume=obj.resume;
        }
    }
    class Program
    {
        public static void Main()
        {
            Person  Deepti=new Person("My Resume is prepared");
            Person deeptibansal=new Person(Deepti);
            Console.WriteLine(deeptibansal.resume);
            deeptibansal.resume="I have learnt Java";
            Console.WriteLine(deeptibansal.resume);


        }
    }
}
