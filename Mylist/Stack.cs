using System.Collections;

namespace Mylist
{
    public class Stack : IEnumerable
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

        public Node Top { get; private set; } //первый элемент
        int count;

        //  ToArray() ?????????????????????????/ 

        public int Count
        {
            get { return count; }
        }

        public void Push(object item)  //В методе Push() добавляем элемент, при этом увеличивая значение переменной count.
        {
            // увеличиваем стек
            Node node = new Node(item);
            node.Next = Top; // переустанавливаем верхушку стека на новый элемент
            Top = node;
            count++;
        }

        public void Pop() //извлекаем элемент из верхушки стека, при этом уменьшая значение переменной count. 
        {
            Node temp = Top;
            Top = Top.Next; // переустанавливаем верхушку стека на следующий элемент
            count--;
        }

        public object Peek()   // возвращаем значение верхушки
        {
            return Top.Value;
        }

        public void Clear()  // ???
        {
            Top = null;
            count = 0;
        }

        public bool Contains(object obj)
        {
            Node current = Top;
            while (current != null)
            {
                if (current.Value.Equals(obj))
                    return true;
                current = current.Next;
            }
            return false;
        }

        //// реализация интерфейса IEnumerable

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = Top;
            while (current != null)
            {
                yield return current.Value;   //Применяя yield return мы декларируем, что данный метод возвращает последовательность IEnumerable, элементами которой являются результаты выражений каждого из yield return.
                current = current.Next;
            }
        }
    }
}
