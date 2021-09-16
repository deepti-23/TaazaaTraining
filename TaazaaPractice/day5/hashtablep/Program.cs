using System;
using System.Collections;

namespace hashtablep
{
    class Program
    {
        static void Main()
        {
            // Create a hashtable
        // Using Hashtable class
        Hashtable my_hashtable = new Hashtable();
 
        // Adding key/value pair in the hashtable
        // Using Add() method
        my_hashtable.Add("A1", "Welcome");
        my_hashtable.Add("A2", "to");
        my_hashtable.Add("A3", "the World!");
        Console.WriteLine("Key and Value pairs from my_hashtable:");
 
        foreach(DictionaryEntry ele1 in my_hashtable)
        {
            Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
        }

        for (int i=0; i<=)

        // removing the value
        Console.WriteLine();

        my_hashtable.Remove("A2");
 
        Console.WriteLine("Key and Value pairs :");
 
        foreach(DictionaryEntry ele1 in my_hashtable)
        {
            Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
        }

        // Determine whether the given
        // key present or not
        // using Contains method
        Console.WriteLine(my_hashtable.Contains("A3"));
        Console.WriteLine(my_hashtable.Contains(12));
        Console.WriteLine();
 
        // Determine whether the given
        // key present or not
        // using ContainsKey method
        Console.WriteLine(my_hashtable.ContainsKey("A1"));
        Console.WriteLine(my_hashtable.ContainsKey(1));
        Console.WriteLine();
 
        // Determine whether the given
        // value present or not
        // using ContainsValue method
        Console.WriteLine(my_hashtable.ContainsValue("geeks"));
        Console.WriteLine(my_hashtable.ContainsValue("to"));
        }
    }
}
