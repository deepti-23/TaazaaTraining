using System.Collections;
using System.Collections.Generic;
using System;
namespace day6.Collections
{
    public class Candidates
    {
       public string AddCandidatesName() 
       {
           ArrayList arrayList=new ArrayList();
           arrayList.Add("Deepti");  //Boxing
           arrayList.Add("Deepti Bansal");
           string Name=(string)arrayList[1];  //Unboxing
           //Console.WriteLine(Name);
           return Name;
       }
       public void AddCandidatesNames() 
       {
           List<string> obj=new List<string>();
           obj.Add("Deepti");
           obj.Add("Deepti Bansal");
           if (obj.Contains("Deepti Bansal"))  
            {  
                Console.WriteLine("found!");  
            }
            else
            {
                Console.WriteLine(" Not found!");

            }
           
       }
    }
}