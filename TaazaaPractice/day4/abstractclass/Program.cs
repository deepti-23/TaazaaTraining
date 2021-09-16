using System;

namespace abstractclass
{
    public abstract class parent
    {
        
        public abstract void job();

    }
    public class child:parent
    {
        public override void job()
        {
            Console.WriteLine("I am doing job");
        }
        void asset()
        {
            Console.WriteLine("Now you can the access to the asset");
        }
        

    
    public static void Main ()
    {
        var obj =new child();
        obj.job();
        obj.asset();


    }
