using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Elements<int, string> elements = new Elements<int, string>();

            // добавляем в коллекцию пару "ключ-значение"
            elements.AddbyKeyFirst(11, "value 11");
            elements.AddbyKeyFirst(10, "value 10");
            elements.AddbyKeyFirst(9, "value 9");
            elements.AddbyKeyFirst(8, "value 8");
            elements.AddbyKeyFirst(7, "value 7");
            elements.AddbyKeyFirst(6, "value 6");
            elements.AddbyKeyFirst(5, "value 5");
            elements.AddbyKeyFirst(4, "value 4");
            elements.AddbyKeyFirst(3, "value 3");
            elements.AddbyKeyFirst(2, "value 2");
            elements.AddbyKeyFirst(1, "value 1");
            elements.AddbyKeyFirst(0, "value 0");

            //Выводим на экран.
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}", elements[i]);
            }

            Console.WriteLine(new string('-', 20));

            // добавляем в коллекцию "значение" по "ключу"
            elements.AddbyKey(5, "valuebykey 5");
            elements.AddbyKey(8, "valuebykey 8");
            elements.AddbyKey(9, "valuebykey 9");

            //Выводим на экран.
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("{0}", elements[i]);
            }

            Console.WriteLine(new string('-', 20));


            Console.ReadKey();
        }
    }
}
