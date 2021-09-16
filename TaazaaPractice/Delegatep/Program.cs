using System;
using Delegatep.Deligate;
delegate int customdelegate();  //Deligate is a keyword which points to that function which returns int type value
namespace Delegatep
{
    class Program
    {
        static void Main()
        {
           var PersonObj=new Person();
           customdelegate Cobj=new customdelegate(PersonObj.PhoneNumber);
           var Hold=Cobj.Invoke();
           Console.WriteLine(Hold);
           
           Cobj-=PersonObj.walk;     //+= is multicast
           //Cobj+=PersonObj.walking   error because the function returns string type
           var Hold1=Cobj.Invoke();
           Console.WriteLine(Hold1);
        }
    }
}
