using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylist
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Mylist
    {

        public class LinkedList : ICollection// ,IEnumerable
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

            public Node First { get; set; } //первый элемент
            public Node Last { get; set; } // последний элемент
                                                   // public int Count { get; private set; } = 0; // количество элементов
            int count;

            public void Add(object value)  //
            {
                var node = new Node(value);

                if (First == null) First = node;
                else
                    Last.Next = node;

                Last = node;
                count++;
            }

            public void AddFirst(object value)
            {
                var node = new Node(value);

                node.Next = First;
                First = node;
                if (count == 0)
                    Last = First;
                count++;
            }

            public bool RemoveFirst()
            {
                // переустанавливаем значение First

                First = First.Next;
                // если после удаления список пуст, сбрасываем tail
                if (First == null)
                    Last = null;

                count--;
                return true;
            }

            public bool RemoveLast()
            {
                Node current = First;
                Node previous = null;

                while (current != null)
                {
                    if (previous != null && current.Next == null)
                    {
                        Last = previous;
                        Last.Next = null;
                        break;
                    }
                    previous = current;
                    current = current.Next;
                }

                count--;
                return true;
            }

            public void Remove(object value)
            {
                Node current = First;
                Node previous = null;

                while (current != null)
                {
                    if (current.Value.Equals(value))
                    {
                        // Если узел в середине или в конце
                        if (previous != null)
                        {
                            // убираем узел current, теперь previous ссылается не на current, а на current.Next
                            previous.Next = current.Next;

                            // Если current.Next не установлен, значит узел последний,
                            // изменяем переменную tail
                            if (current.Next == null)
                                Last = previous;
                        }
                        else RemoveFirst(); // если удаляется первый элемент

                        count--;
                    }

                    previous = current;
                    current = current.Next;
                }
            }

            // содержит ли список элемент
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


            public void Clear()
            {
                First = null;
                Last = null;
                count = 0;
            }

            // ???
            //для того, чтобы список можно было бы перебрать во внешней прграмме с помощью цикла for-each, класс списка реализует интерфейс IEnumerable:

            //IEnumerator IEnumerable.GetEnumerator()
            //{
            //    return ((IEnumerable)this).GetEnumerator();
            //}

            IEnumerator IEnumerable.GetEnumerator()
            {
                Node current = First;
                while (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }
            }



            //public IEnumerator GetEnumerator() // метод кот возвращает интерфейс IEnumerator  - дает возможность ходить по нашему листу или коллекции
            //{
            //    // return inner.GetEnumerator();  у массива уже реализован  Enumerator
            //    return new ListEnumerator(inner);
            //}


            public object[] ToArray() ///------
            {
                Node[] LinkedListToArray = new Node[count];

                Node current = First;
                Node previous = null;
                int index = 0;
                while (current != null)
                {
                    LinkedListToArray[index] = current;
                    index++;

                }

                previous = current;
                current = current.Next;

                return LinkedListToArray;
            }

            //// реализация интерфейса IEnumerable

               

            //IEnumerator IEnumerable.GetEnumerator()
            //{
            //    Node current = First;
            //    while (current != null)
            //    {
            //        yield return current.Value;   //Применяя yield return мы декларируем, что данный метод возвращает последовательность IEnumerable, элементами которой являются результаты выражений каждого из yield return.
            //        current = current.Next;
            //    }

            //}
        }
    }
}

