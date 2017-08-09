using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylist
{
    public class List //: ICollection //, IComparable, ICloneable -реализация множественного наследования в C#. но если еще наследуется от класса то он должен быть в самом начале
    {
        public object this[int index]   //св-во индексатор, позволяет передвигаться по массиву
        {
            get
            {
                return inner[index];
            }
        }

        private object[] inner = new object[0];

        public int Length
        {
            get
            {
                return inner.Length;
            }

        }

        //  public int Count { get; private set; } = 1;

        public void Add(object item)
        {
            var temp = new object[Length + 1];

            for (int i = 0; i < Length; i++)
            {
                temp[i] = inner[i];
            }

            temp[Length] = item;
            inner = temp;

            //Array.Resize(ref inner, inner.Length + 1);
            //inner[inner.Length] = obj;
        }

        public void RemoveAt(int index)
        {
            var temp = new object[Length - 1];
            for (int i = 0, j = 0; i < Length && j < temp.Length; i++, j++)
            {
                if (i == index) i++;

                temp[j] = inner[i];

            }
            inner = temp;
        }

        public void Insert(object item, int index)
        {
            var temp = new object[Length + 1];

            for (int i = 0, j = 0; i < Length ; i++, j++)
            {
                if (i == index)
                {
                    temp[j] = item;
                    j++;
                }
                temp[i] = inner[i];
            }

            inner = temp;


        }



        /* public void Insert(int index, object item)
         {
             var newArr = new object[Count + 1];
             Array.Copy(inner, newArr, index);
             newArr[index] = item;
             Array.Copy(inner, index, newArr, index + 1, Count - index);
             inner = newArr;
             Count++;
         }

         public void Remove(object obj)
         {
             for (int i = 0; i < Count-1; i++)
             {
                 if (inner[i].Equals(obj))
                 {
                     RemoveAt(i);
                     Count--;
                     return;
                 }
             }
         }

         public void RemoveAt(int i)
         {
             var newArr = new object[Count - 1];
             Array.Copy(inner, newArr, i);
             Array.Copy(inner, i + 1, newArr, i, Count - i);
             inner = newArr;
             Count--;
         }

         public void Clear()
         {
             inner = new object[0];
         }

         public bool Contains(object obj)
         {
             foreach (var item in inner)
                 if (item.Equals(obj))
                     return true;
             return false;
         }

         public int IndexOf(object obj)
         {
             for (int i = 0; i < Count; i++)
             {
                 if (inner[i].Equals(obj))
                     return i;
             }
             return -1;
         }

         public object[] ToArray() // возвращает копию в виде массива
         {
             var copy = new object[Count];
             Array.Copy(inner, copy, Count);
             return copy;
         }

         public void Reverse()
         {
             Array.Reverse(inner);
         }

         /// <summary>
         /// ///////////////
         /// </summary>

         private class ListEnumerator : IEnumerator // создадим свой Enumerator , реализует возможность ноды - Current, MoveNext
         {
             private object[] arr;
             private int index = 0;

             public ListEnumerator(object[] array)
             {
                 arr = array;
             }

             public object Current // Текущий обьект
             {
                 get
                 {
                     return arr[index]; //сохраняем имндекс текущего элемента и возврщаем Current
                 }
             }

             public bool MoveNext()  // двигаться к следующему
             {
                 if (++index < arr.Length)
                     return true;
                 else return false;
             }

             public void Reset()
             {
                 index = -1;
             }
         }
         /// <summary>
         /// ///////
         /// </summary>
         /// <returns></returns>


         public IEnumerator GetEnumerator() // метод кот возвращает интерфейс IEnumerator  - дает возможность ходить по нашему листу или коллекции
         {
             // return inner.GetEnumerator();  у массива уже реализован  Enumerator
             return new ListEnumerator(inner);
         } */
    }
    }
