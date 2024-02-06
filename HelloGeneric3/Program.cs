using System;
using System.Collections.Generic;

namespace HelloGeneric3
{
    class Program
    {
        static void Main(string[] args)
        {
            //例子1：创建一个新的整数类型列表
            IList<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //例子2：带有两个参数的泛型接口和泛型类（参数内容是key和value）
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "Timothy";
            dict[2] = "Michael";
            Console.WriteLine($"student #1 is {dict[1]}");
            Console.WriteLine($"student #1 is {dict[1]}");

            //例子3：泛型方法的使用
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = { 1, 2, 3, 4, 5, 6 };
            double[] a3 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] a4 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            var result = Zip(a1, a2);
            Console.WriteLine(string.Join(",", result));
        }

        //泛型方法的定义
        static T[] Zip<T>(T[] a, T[] b)
        {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < a.Length) zipped[zi++] = a[ai++];
                if (bi < b.Length) zipped[zi++] = b[ai++];
            } while (ai<a.Length || bi<b.Length);
            return zipped; 
        }
    }
}
