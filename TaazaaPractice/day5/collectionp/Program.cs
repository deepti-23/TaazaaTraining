using System;
using collectionp.models;
using collectionp.Taazaa;


namespace collectionp
{
    class Program
    {
        static void Main()
        {
            /* var obj=new Candidatelist();        // returning name one by one 
            var s=obj.Candidatedetails(); 
            Console.WriteLine(s); */


            /* var obj=new Candidatelist();
            var arrayList=obj.Candidatedetails();
            int count=arrayList.Count;
            int i=0;
            while(i<count)
            {
                Console.WriteLine(arrayList[i]);
                i++;
            }   */ 

            var objlist=new Candidatelist();
            var list =objlist.Candidatedetail();
            int count=list.Count;
            for (int i=0; i<count;i++)
            {
                Console.WriteLine(list[i].cid+" "+list[i].cname);
            }      
        }
    }
}
