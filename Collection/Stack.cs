using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Stack<T> : Collection<T>
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Stack():base()
        {
        }

        /// <summary>
        /// Создание стека с capacity элементов
        /// </summary>
        /// <param name="capacity"></param>
        public Stack(int capacity):base(capacity)
        {
        }

        /// <summary>
        /// Создание стека из массива элементов
        /// </summary>
        /// <param name="copyItems"></param>
        public Stack(T[] copyItems):base(copyItems)
        {
        }
        /// <summary>
        /// Добавление элемента в стек
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
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
        /// Извлечение элемента из стека
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            var popItem = Peek();
            var b = new T[Count - 1];
            Array.ConstrainedCopy(items, 0, b, 0, Count - 1);
            items = b;
            return popItem;
        }

        /// <summary>
        /// Возврат верхнего элемента стека
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

            return items.Last();
        }
    }
}
