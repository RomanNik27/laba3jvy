using Collections;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    uint i; string s;
                    do
                    {
                        Console.WriteLine("Тестирование коллекций");
                        Console.WriteLine("1 - стек");
                        Console.WriteLine("2 - очередь");
                        Console.WriteLine("3 - массив");
                        Console.WriteLine("0 - выход");
                        s = Console.ReadLine();
                    } while (!uint.TryParse(s, out i) || i > 3);

                    switch (i)
                    {
                        case 0:
                            return;
                        case 1:
                            TestStack();
                            break;
                        case 2:
                            TestQueue();
                            break;
                        case 3:
                            TestArray();
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            Console.ReadLine();
        }

        private static void TestArray()
        {
            uint i; string s;
            var aray = new string[] { "One", "Two", "Three" };
            var array = new Array<string>(aray);
            while (true)
            {
                do
                {
                    Console.WriteLine("Тестирование методов массива");
                    Console.WriteLine("1 - Элемент в массиве");
                    Console.WriteLine("2 - Количество элементов");
                    Console.WriteLine("3 - Очистка массива");
                    Console.WriteLine("4 - Проверка содержания элемента");
                    Console.WriteLine("0 - выход");
                    s = Console.ReadLine();
                } while (!uint.TryParse(s, out i) || i > 4);

                switch (i)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            int index; string str;
                            do
                            {
                                Console.WriteLine("Введите индекс");
                                str = Console.ReadLine();
                            }
                            while (!int.TryParse(str, out index));

                            try
                            {
                                Console.WriteLine($"Элемент {index} массива - {array[index]}");
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine($"Ошибка: {exception}");
                            }

                        }
                        break;
                    case 2:
                        try
                        {
                            var count = array.Count;
                            Console.WriteLine($"Количество элементов: {count}");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 3:
                        try
                        {
                            array.Clear();
                            Console.WriteLine($"Массив очищен.");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 4:
                        string str1;

                        Console.WriteLine("Введите элемент для поиска");
                        str1 = Console.ReadLine();

                        try
                        {
                            var contains = array.Contains(str1);
                            Console.WriteLine($"Элемент {str1}" + (contains ? " найден" : " не найден"));
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                }
            }
        }

        private static void TestQueue()
        {
            uint i; string s;
            var queue = new Queue<decimal>(4);
            while (true)
            {
                do
                {
                    Console.WriteLine("Тестирование методов очереди");
                    Console.WriteLine("1 - Добавление элемента");
                    Console.WriteLine("2 - Извлечение элемента");
                    Console.WriteLine("3 - Крайний элемент очереди");
                    Console.WriteLine("4 - Количество элементов");
                    Console.WriteLine("5 - Очистка очереди");
                    Console.WriteLine("6 - Проверка содержания элемента");
                    Console.WriteLine("0 - выход");
                    s = Console.ReadLine();
                } while (!uint.TryParse(s, out i) || i > 6);

                switch (i)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            decimal item; string str;
                            do
                            {
                                Console.WriteLine("Введите элемент - вещественное число");
                                str = Console.ReadLine();
                            }
                            while (!decimal.TryParse(str, out item));

                            try
                            {
                                queue.Enqueue(item);
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine($"Ошибка: {exception}");
                            }

                        }
                        break;
                    case 2:
                        try
                        {
                            var item = queue.Dequeue();
                            Console.WriteLine($"Извлечен элемент : {item}");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 3:
                        try
                        {
                            var peekItem = queue.Peek();
                            Console.WriteLine($"Крайний элемент : {peekItem}");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 4:
                        try
                        {
                            var count = queue.Count;
                            Console.WriteLine($"Количество элементов: {count}");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 5:
                        try
                        {
                            queue.Clear();
                            Console.WriteLine($"Очередь очищена.");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 6:
                        decimal item1; string str1;
                        do
                        {
                            Console.WriteLine("Введите элемент - вещественное число");
                            str1 = Console.ReadLine();
                        } while (!decimal.TryParse(str1, out item1));
                        try
                        {
                            var contains = queue.Contains(item1);
                            Console.WriteLine($"Элемент {item1}" + (contains ? " найден" : " не найден"));
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                }
            }
        }

        static void TestStack()
        {
            uint i; string s;
            var stack = new Stack<int>();
            while (true)
            {
                do{
                    Console.WriteLine("Тестирование методов стека");
                    Console.WriteLine("1 - Добавление элемента");
                    Console.WriteLine("2 - Извлечение элемента");
                    Console.WriteLine("3 - Верхушка стека");
                    Console.WriteLine("4 - Количество элементов");
                    Console.WriteLine("5 - Очистка стека");
                    Console.WriteLine("6 - Проверка содержания элемента");
                    Console.WriteLine("0 - выход");
                    s = Console.ReadLine();
                } while (!uint.TryParse(s, out i) || i > 6) ;

                 switch (i)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            int item; string str;
                            do
                            {
                                Console.WriteLine("Введите элемент стека - число");
                                str = Console.ReadLine();
                            }
                            while (!int.TryParse(str, out item));
                            
                                try
                                {
                                    stack.Push(item);
                                }
                                catch (Exception exception)
                                {
                                    Console.WriteLine($"Ошибка: {exception}");
                                }
                            
                        }
                        break;
                    case 2:
                        try
                        {
                            var popItem = stack.Pop();
                            Console.WriteLine($"Извлечен элемент стека: {popItem}");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 3:
                        try
                        {
                            var peekItem = stack.Peek();
                            Console.WriteLine($"Верхний элемент стека: {peekItem}");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 4:
                        try
                        {
                            var count = stack.Count;
                            Console.WriteLine($"Количество элементов стека: {count}");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 5:
                        try
                        {
                            stack.Clear();
                            Console.WriteLine($"Стек очищен.");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"Ошибка: {exception}");
                        }
                        break;
                    case 6:
                        int item1; string str1;
                        do
                        {
                            Console.WriteLine("Введите элемент стека - число");
                            str1 = Console.ReadLine();
                        } while (!int.TryParse(str1, out item1));
                            try
                            {
                                var contains = stack.Contains(item1);
                                Console.WriteLine($"Элемент {item1}" + (contains ? " найден" : " не найден"));
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine($"Ошибка: {exception}");
                            }
                        break;
                }
            }
        }
     
    }
}
