using Mylist.Mylist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List();

            Console.WriteLine(list.Length);
            list.Add(10);
            list.Add(30);
            list.Add(50);
            list.Add(60);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            // list.RemoveAt(3);

            Console.WriteLine("----------");
            list.Insert(666,0);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            //// linked list
            /////////////////////////////////
            //var linkedList = new LinkedList();
            ////добавление элементов
            //linkedList.Add("Tom");
            //linkedList.Add("Alice");
            //linkedList.Add("Bob");
            //linkedList.Add("Sam");

            ////выводим элементы
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            //linkedList.ToArray();







            /////////////////////////////////

            //queue
            //var queue = new Queue();
            //queue.Enqueue("Kate");
            //queue.Enqueue("Sam");
            //queue.Enqueue("Alice");
            //queue.Enqueue("Tom");

            //foreach (string item in queue)
            //    Console.WriteLine(item);


            //Console.WriteLine();

            ////queue.Clear();

            //string x=queue.Peek().ToString();

            //Console.WriteLine("VVVV"+x);

            //bool x = queue.Contains("Tom1");

            //if (x == true) Console.WriteLine("yes");






            //foreach (string item in queue)
            //    Console.WriteLine(item);






            //stack
            ////////////////////////////////////////////////////////
            // var stack = new Stack();
            // stack.Push("Tom");
            // stack.Push("Alice");
            // stack.Push("Bob");
            //stack.Push("Kate");

            // foreach (var item in stack)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("---------------------");

            // stack.Clear();

            // bool x = stack.Contains("Alice1");

            // if (x == true) Console.WriteLine("yes");

            // foreach (var item in stack)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("---------------------");

            // string header = stack.Peek().ToString();
            // Console.WriteLine($"Верхушка стека: {header}");
            // Console.WriteLine();

            // stack.Pop();

            // foreach (var item in stack)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("---------------------");
            // header = stack.Peek().ToString();
            // Console.WriteLine($"Верхушка стека: {header}");
            // Console.WriteLine();

            ///////////////////////////////////////////////////////////////

            //var MyList = new Queue();
            //{
            //    100,
            //    200,
            //    300
            //};
            //ICollection collection1 = MyList;  // приводим наш обьект к интерфейсу
            // collection1.Add(k); // теперь  для сollection1 доступны методы Add etc

            //var MyLinkedList = new LinkedList();
            //collection1 = MyLinkedList;                              //можно привести к коллекции LinkedList и соответсвеено пользоваться методами LinkedList
            //collection1.Clear();

            //    MyList.Add(500);

            //MyList.Enqueue(200);

            //Console.WriteLine(MyList.Last);

            //foreach (var item in MyList)
            //{
            //    Console.WriteLine(item);
            //}


            //    foreach (var item in collection1)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("-----------");

            //    MyList.Insert(2,400);

            //    foreach (var item in collection1)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("-----------");


            //    MyList.RemoveAt(2);

            //    foreach (var item in collection1)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("-----------");

            //}


        }
    }
}