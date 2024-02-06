using System;
using System.Collections.Generic;

namespace HelloGeneric
{
    class Program
    {
        /// <summary>
        /// 为了避免类型膨胀和成员膨胀，所以要用到泛型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Apple apple = new Apple() { Color = "red" };
            Book book = new Book() { Name = "New Book" };
            Box<Apple> box1 = new Box<Apple>() { Cargo = apple };
            Box<Book> box2 = new Box<Book>() { Cargo  = book };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);
        }

        class Apple
        {
            public string Color { set; get; }
        } 
        class Book
        {
            public string Name { get; set; }
        }
        class Box<TCargo>
        {
            public TCargo Cargo { get; set; }
        }
    }
}
