using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Array<T> : Collection<T>
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Array():base()
        {
      
        }

        public Array(int capacity):base(capacity)
        {
        
        }

        public Array(T[] copyItems):base(copyItems)
        {

       }

        /// <summary>
        /// Элемент массива
        /// </summary>
        /// <param name="index"> Индекс элемента</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new Exception("Индекс выходит за границы массива");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new Exception("Индекс выходит за границы массива");
                }
                items[index] = value;
            }
        }
    }
}
