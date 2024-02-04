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
            AppleBox box = new AppleBox() { Cargo = apple };
            Console.WriteLine(box.Cargo.Color);

            Book book = new Book() { Name = "New Book" };
            BookBox bookBox = new BookBox() { Cargo = book };
            Console.WriteLine(bookBox.Cargo.Name);
        }

        class Apple
        {
            public string Color { set; get; }
        }
        class AppleBox
        {
            public Apple Cargo { get; set; }
        }
        class Book
        {
            public string Name { get; set; }
        }
        class BookBox
        {
            public Book Cargo { get; set; }
        }
    }
}
