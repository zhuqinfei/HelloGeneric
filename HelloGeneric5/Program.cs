using System;

namespace HelloGeneric5
{
    class Program
    {
        static void Main(string[] args)
        {
            //有返回值泛型委托，第一个类型是返回值类型，第二个类型和第三个类型分别对应两个参数类型
            Func<double, double, double> func1 = Add;
            //使用Lambda表达式或匿名函数来将方法直接编写到对象的实例化上
            //Func<double, double, double> func2 = (a,b)=> { return a +b; };
            var result = func1(100.1, 200.2);
            Console.WriteLine(result);

        }
        static int Add(int a ,int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
