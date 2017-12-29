using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public abstract class Collection<T>
    {
        protected T[] items;

        // Конструктор по умолчанию
        public Collection()
        {
            items = new T[0];
        }
        public Collection(int capacity)
        {
            items = new T[capacity];
        }

        public Collection(T[] copyItems)
        {
            items = new T[copyItems.Length];
            for (int i = 0; i < copyItems.Length; i++)
            {
                items[i] = copyItems[i];
            }
        }
        /// <summary>
        /// Количество элементов коллекции
        /// </summary>
        public int Count
        {
            get
            {
                if (items == null)
                {
                    throw new Exception("Collection not created");
                }
                return items.Length;
            }
        }

        /// <summary>
        /// Очищает всю коллекцию объектов
        /// </summary>
        public void Clear()
        {
            if (items == null)
            {
                throw new Exception("Collection not created");
            }
            items = new T[0];
        }

        /// <summary>
        /// Ищет элемент в коллекции
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            if (items == null)
            {
                throw new Exception("Collection not created");
            }
            return items.Contains(item);
        }
       
    }
}
