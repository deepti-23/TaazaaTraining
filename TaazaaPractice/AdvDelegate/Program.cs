using System;
using AdvDelegate.Arithmatic;
delegate void Airithmaticdelegate(double D1,double D2);

namespace AdvDelegate
{
    class Program
    {
        static void Main()
        {
            /* 1.  Airithmaticdelegate obj=new Airithmaticdelegate(AirithematicOperation.Addition);
            //obj.Invoke(2,3);
            obj+=AirithematicOperation.Multiplication;
            //obj.Invoke(5,7);
            obj+=AirithematicOperation.Division;
            obj.Invoke(6,3);
            obj.Invoke(5,7); */ 


            Airithmaticdelegate obj=delegate(double D1,double D2)
            {
                Console.WriteLine(D1+D2);
            };

            Airithmaticdelegate obj1=delegate(double D1,double D2)  // Anonymous Method
            {
                Console.WriteLine(D1*D2);
            };

            Airithmaticdelegate obj3=(double D1,double D2)=>  //lambda function   ==> operator 
            {
                Console.WriteLine(D1-D2);
            };

            obj(10,5);
            obj1(2,5);
            obj3(15,4);
            

        }
        
    }
}
