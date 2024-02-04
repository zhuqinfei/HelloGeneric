using System;

namespace HelloGeneric2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<int> student = new Student<int>();
            student.Id = 101;
            student.Name = "Tony";
        }
    }
    interface IUnique<TId>
    {
        TId Id { get; set; }
    }
    class Student<TId>:IUnique<TId>
    {
        public TId Id { get; set; }
        public string Name { get; set; }

    }
}
