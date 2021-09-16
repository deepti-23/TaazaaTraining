using System;
using advgenerics.Models;
using System.Collections.Generic;
using advgenerics.TrainingList;
namespace advgenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1=new TaazaaTrainingList();
            List<Details>temp=obj1.TrainingList();
            int t =temp.Count;
            int i=0;
            while(i<t)
            {
                Console.WriteLine(temp[i].PhoneNumber+" "+temp[i].Email);
                i++;

            }

            
        }
    }
}
