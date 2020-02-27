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
        }
    }
}
