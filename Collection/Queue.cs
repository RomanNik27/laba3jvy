using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Queue<T>:Collection<T>
    {

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Queue():base()
        {
        }
      
        public Queue(int capacity):base(capacity)
        {
        }
        public Queue(T[] copyItems):base(copyItems)
        {
        }
        /// <summary>
        /// Извлечение крайнего элемента из очереди
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            var item = Peek();

            var b = new T[Count - 1];
            Array.ConstrainedCopy(items, 1, b, 0, Count - 1);
            items = b;

            return item;
        }

        /// <summary>
        /// Добавление элемента в очередь
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            if (items == null)
            {
                throw new Exception("Collection not created");
            }
            var b = new T[Count + 1];
            Array.Copy(items, b, Count);
            b[Count] = item;
            items = b;
        }

        /// <summary>
        /// Возврат крайнего элемента очереди
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (items == null)
            {
                throw new Exception("Collection not created");
            }
            if (Count == 0)
            {
                throw new Exception("Collection is empty");
            }
            return items.First();
        }
    }
}
