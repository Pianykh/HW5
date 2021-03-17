using System;
using System.Text;

/*
 * 2.Создать некую книгу имен. Имена могуть быть как на латыни так и на кириллице.
 * Пользователь может добавить имя, удалить его, вывести весь список имен. 
 * Т.е. программа должна запрашивать какое действие хочет сделать пользователь, и после уже идет его выполнение.
 * Учесть ввод невалидных данных. Выполнить с использованием методов, массивов и циклов.
*/

namespace Ex2
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var newBook = CreateBook();
            Console.WriteLine("Создана книга имен. Доступные действия:");
            int key;
            do
            {
                Console.WriteLine("1. Добавить имя. 2. Удалить имя. 3. Отобразить все имена. 4. Выход");
                Console.WriteLine("Введите цифру соответствующую действию:");
                var input = Console.ReadLine();
                if (int.TryParse(input, out key))
                {
                    if (key == 1)
                    {
                        Console.WriteLine("Введите имя для добавления:");
                        var name = Console.ReadLine();
                        AddName(name, ref newBook);
                    }
                    else if (key == 2)
                    {
                        Console.WriteLine("Введите имя для удаления:");
                        var name = Console.ReadLine();
                        DeleteName(name, ref newBook);
                    }
                    else if (key == 3)
                    {
                        DisplayBook(ref newBook);
                    }                    
                    else if (key > 4 || key < 1) Console.WriteLine("Некорректная команда.");
                }
                else Console.WriteLine("Некорректная команда.");
            } while (key != 4);            
        }

        static void AddName(string name, ref string[] book)
        {
            Array.Resize(ref book, book.Length + 1);
            book[book.Length - 1] = name;
        }
        static void DeleteName(string name, ref string[] book)
        {
            for (var i = 0; i < book.Length; i++)
            {
                if (book[i] == name)
                {
                    Console.WriteLine($"Пользователь {book[i]} удален");
                    for (var k = i + 1; k < book.Length; k++)
                    {
                        book[i] = book[k];
                        i++;
                    }
                    Array.Resize(ref book, book.Length - 1);
                    return;
                }                
            }
            Console.WriteLine("В книге нет такого имени");

        }
        static void DisplayBook(ref string[] book)
        {
            if (book.Length != 0)
            {
                foreach (var name in book)
                {
                    Console.WriteLine(name);
                }
            }
            else Console.WriteLine("Книга пустая.");
        }

        static string[] CreateBook()
        {
            return new string[0];
        }
    }
}
