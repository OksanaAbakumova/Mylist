using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mylist
{
    // IEnumerable -стандартный интерфейс дотнета для перечислений - для того что что по сути не является коллекцией но может иметь итерационный подход (те если мы реализуем у своего класса IEnumerable, то можем ходить по нему forech

    interface ICollection : IEnumerable
    {
       // int Count { get; }

        void Add(object obj);
      //  void Remove(object obj);
      //  void Clear();




    }
}