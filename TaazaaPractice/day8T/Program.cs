using System;
using day8T.AdvDelegate;

//delegate string Stringdelegate(string N1);
/* delegate void Voiddelegate();
delegate bool Booldelegate(); */

namespace day8T
{
    class Program
    {
        static void Main()
        {
            Study study=new Study();
            /* Stringdelegate stringdelegate=new Stringdelegate(study.Name);
            Console.WriteLine(stringdelegate.Invoke("Deepti")); */

            Func<string,string> func=study.Name;
            string f=func("Deepti");
            Console.WriteLine(f);

            Action action=study.PhoneNumber;
            action();

            Predicate<string> predicate=study.studyStatus;
            bool pd=predicate("gupta");
            Console.WriteLine(pd);

        }
    }
}
