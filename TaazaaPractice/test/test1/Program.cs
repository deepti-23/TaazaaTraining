using System;

namespace test1
{
    public abstract class Taaza
    {
        public abstract  void Discipline();


    }
    public class Employee:Taaza
    {
        public override void Discipline()
        {
            Console.WriteLine("I am in proper Discipline");
        }
        public void Hobby()
        {
            Console.WriteLine("My Hobby Is Listining Music");
        }
        public static void Main()
        {
            var obj=new Employee();
            obj.Discipline();
            obj.Hobby();
        }
    }
}
