using System;

namespace HelloGeneric4
{
    class Program
    {
        static void Main(string[] args)
        {
            //无返回值泛型委托
            Action<string> a1 = Say;
            a1("Timothy");
            Action<int> a2 = Mul;
            a2(1);

        }

        static void Say(string str)
        {
            Console.WriteLine($"Hello,{str}");
        }
        static void Mul(int x)
        {
            Console.WriteLine(x * 100);
        }
    }
}
