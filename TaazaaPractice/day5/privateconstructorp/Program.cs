using System;

namespace privateconstructorp
{
    class constructor {
  
    // Variables
    public static string name;
    public static int num;
  
    // Creating private Constructor
    // using private keyword
    private constructor() {
  
        Console.WriteLine("Welcome to Private Constructor");
    }
  
    // Default Constructor
    // with parameters
    public constructor(string a, int b) {
  
        name = a;
        num = b;
    }
}
  
// Driver Class
class Program {
  
    // Main Method
    static void Main() {
  
        // This line raises error because
        // the constructor is inaccessible
        // constructor obj1 = constructor Geeks();
  
        // Here, the only default 
        // constructor will invoke
        constructor obj2 = new constructor("Deepti", 23);
  
        // Here, the data members of Geeks
        // class are directly accessed
        // because they are static members
        // and static members are accessed 
        // directly with the class name
        Console.WriteLine(constructor.name + ", " + constructor.num);
    }
}
}
