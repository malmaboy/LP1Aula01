using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string normal = "Hello world";
            string tentativa = "Um tab\t e um copyright\u03A9";
            string meh = @"""esta string esta' entre aspas""";
            string meeh = "\"Esta stings esta entre aspas\"";
            string try1 = @"C:\Users\Ana\Documents";
            string try2 = @"Nao é um codigo Unicode \u1234, nao e' nova linha";

            

            Console.WriteLine(normal);
            Console.WriteLine(tentativa);
            Console.WriteLine(meh);
            Console.WriteLine(meeh);
            Console.WriteLine(try1);
            Console.WriteLine(try2);



            string x = "meh";
            string y = "meeh";
            string v1 = "toto";
            string v0 = "mundo";
            string z = "andre";

            string s = String.Format("Arg {0} e {1}", x, y);
            string meeeh = String.Format("Arg {0} e {1}", v1, v0);
            string tr = String.Format("Ola {0} e {1}!", "mundo", 3);
            Console.WriteLine("Valor de z é {0}", z);

            Console.WriteLine(s);
            Console.WriteLine(meeeh);
            Console.WriteLine(tr);

        }
    }
}
