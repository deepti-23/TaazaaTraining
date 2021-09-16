using System;

namespace Array2.Array3
{
    public class ArrayExample
    {

        public  void NormalArray()
        {
        int[] arr = { 10, 20, 30, 40, 50 };//creating and initializing array  
   
        //traversing array  
        foreach (int i in arr)  
        {  
            Console.WriteLine(i);  
        }  
        }
        public  void printArray(int[] arr)  
        {  
            Console.WriteLine("Printing array elements:");  
            for (int i = 0; i < arr.Length; i++)  
            {  
                Console.WriteLine(arr[i]);  
            } 
        }
    }    
}