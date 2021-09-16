using System;
using System.Collections.Generic;

namespace dictionaryp
{
    class Program
    {
        static void Main()
        {
            // Creating a dictionary
        // using Dictionary<TKey,TValue> class
        Dictionary<int, string> My_dict =  
                      new Dictionary<int, string>(); 
            
          // Adding key/value pairs in the 
          // Dictionary Using Add() method
          My_dict.Add(101, "Hello!");
          My_dict.Add(102, "I am Deepti");
          My_dict.Add(103, "I love doing Drama");
          Console.WriteLine("Creation of Dictionary(Insertion OF element)");
          foreach(KeyValuePair<int, string> element in My_dict)
          {
              
              Console.WriteLine("{0} and {1}",
                        element.Key, element.Value);
          }
          Console.WriteLine();

                //Another Way to create the Dictionary

        /*   Dictionary<string, string> My_dict2 =  
              new Dictionary<string, string>(){
                                  {"1", "Dog"},
                                  {"2", "Cat"},
                                {"3", "Pig"} }; 
           
          foreach(KeyValuePair<string, string> ele2 in My_dict2)
          {
              Console.WriteLine("{0} {1}", ele2.Key, ele2.Value);
              
          }   */

          Console.WriteLine("Performing Removal of Value 101");
          Console.WriteLine();

          // to remove the key and value from the dictionary My_dict

          My_dict.Remove(101);

          // after removal of the key value pair

          foreach(KeyValuePair<int, string> element in My_dict)
          {
              Console.WriteLine("{0} and {1}",
                        element.Key, element.Value);
          }
          Console.WriteLine();

          // Searching 
          // Using ContainsKey() method to check
          // the specified key is present or not
          Console.WriteLine("performing searching");
          Console.WriteLine();
          if (My_dict.ContainsKey(102)==true)
          {
              Console.WriteLine("102 Key is found...!!");
          }
  
          else
          {
               Console.WriteLine("102 Key is not found...!!");
          }


          // Using ContainsValue() method to check
          // the specified value is present or not
          if (My_dict.ContainsValue("Hello!")==true)
          {
              Console.WriteLine("Hello! Value is found...!!");
          }
  
          else
          {
               Console.WriteLine("Hello! Value is not found...!!");
          }
    
        }
    }
}
