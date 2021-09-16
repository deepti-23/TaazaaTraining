using System;
using Array2.Array3;

namespace Array2
{
    class Program
    {
        static void Main()
        {
            ArrayExample arrayExample=new ArrayExample();
            arrayExample.NormalArray();
            int[] arr1 = { 25, 10, 20, 15, 40, 50 };  
            int[] arr2 = { 12, 23, 44, 11, 54 };  
            arrayExample.printArray(arr1);//passing array to function  
            arrayExample.printArray(arr2);  
        
        }
    }
}
