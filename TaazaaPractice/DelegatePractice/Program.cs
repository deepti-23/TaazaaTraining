using System;
using DelegatePractice.Noida;
delegate int Brokerdelegate();

namespace DelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var Brokerobj=new Broker();
            Brokerdelegate BDobj=new Brokerdelegate(Brokerobj.Flat1);
            Console.WriteLine(BDobj.Invoke());
            BDobj+=Brokerobj.Flat3;
            Console.WriteLine(BDobj.Invoke());



        }
    }
}
