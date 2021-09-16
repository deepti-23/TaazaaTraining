using System;

namespace Array3
{
    class Program
    {
        static void printMin(int[] arr)  
    {  
        int min = arr[0]; 
        int max = arr[0]; 
        for (int i = 1; i < arr.Length; i++)  
        {  
            if (min > arr[i])  
            {  
                min = arr[i];  
            } 

            if (max < arr[i]) 
            {
                max=arr[i];
            }
        }  
        Console.WriteLine("Minimum element in the Array is: " + min);
        Console.WriteLine("Maximum element in the Array is: " + max);  
    }  
    public static void Main(string[] args)  
    {  
        int[] arr1 = { 25, 10, 20, 15, 40, 50 };  
        int[] arr2 = { 12, 23, 44, 11, 54 };  
  
        printMin(arr1);  
        printMin(arr2);  
    }  
    }
}
