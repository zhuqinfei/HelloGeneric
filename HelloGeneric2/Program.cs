using System;

namespace HelloGeneric2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 101;
            student.Name = "Tony";
        }
    }
    interface IUnique<TId>
    {
        TId Id { get; set; }
    }

    //在基类中给泛型接口加了类型，后续创建实例就不用加了
    class Student:IUnique<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
