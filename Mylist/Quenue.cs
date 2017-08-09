using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylist
{
    public class Queue : IEnumerable
    {
        public class Node
        {
            public Node Next;
            public object Value;

            public Node(object value)
            {
                Value = value;
            }
        }


        public Node First { get; private set; } //первый элемент
        public Node Last { get; private set; } // последний элемент
        int count;
        //public int Count { get; private set; } = 0; // количество элементов

        //object Peek()    Возвращает объект, находящийся в начале очереди Queue<T>, но не удаляет его.

     

        public object Peek()   
        {
            return First.Value;
        }


        public void Enqueue(object value)  //ставим в очередь -добавлять элемент
        {
            //Для добавления в очередь нам надо переустановить ссылку на последний элемент tail:
            var node = new Node(value);
            Node tempNode = Last;
            Last = node;
            if (count == 0)
                First = Last;
            else
                tempNode.Next = Last;
            count++;
        }



        public void Dequeue()  //убирать из очереди -убирать элемент
        {
            // При удалении надо переустановить ссылку на первый элемент. Так как первый элемент удаляется, то новым первым элементом становится следующий за ним

            var output = First.Value;
            First = First.Next;
            count--;
        }

        public void Clear()
        {
            First = null;
            Last = null;
            count = 0;

        }

        public bool Contains(object obj)
        {
            Node current = First;
            while (current != null)
            {
                if (current.Value.Equals(obj))
                    return true;
                current = current.Next;
            }
            return false;
        }


 
        //// реализация интерфейса IEnumerable ???


        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = First;
            while (current != null)
            {
                yield return current.Value;   //Применяя yield return мы декларируем, что данный метод возвращает последовательность IEnumerable, элементами которой являются результаты выражений каждого из yield return.
                current = current.Next;
            }

        }






        public Array ToArray()
        {
            Node[] QuenueToArray = new Node[count];

            Node current = First;
            Node previous = null;
            int index = 0;
            while (current != null)
            {
                QuenueToArray[index] = current;
                index++;

            }

            previous = current;
            current = current.Next;

            return QuenueToArray;
        }


    }
}