using System;

namespace HelloGeneric
{
    class Program
    {
        /// <summary>
        /// 这种情况就是类型膨胀，目前就两种商品，就需要两种类型，如果有几千个类型，就会
        /// 要写几千种类型的类，所以这种情况是需要改良。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Apple apple = new Apple() { Color = "red" };
            Book book = new Book() { Name = "New Book" };
            ///改成用一个盒子装也有问题，这样容易导致类成员变量膨胀，当我们只调用一个成员，
            ///如果有几千个成员，那么就会导致成员膨胀情况
            Box box1 = new Box() { Apple = apple };
            Box box2 = new Box() { Book = book };
        }

        class Apple
        {
            public string Color { set; get; }
        }
        class Book
        {
            public string Name { get; set; }
        }
        class Box
        {
            public Apple Apple { get; set; }
            public Book Book { get; set; }
        }
    }
}
