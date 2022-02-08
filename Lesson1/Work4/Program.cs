// программа обмена значениями двух переменных типа int без методов с третей переменной
//Степанов Антон
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    class Program
    {
        static void Pause()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Anton Stepanov (C)";

            int a, b, temp;
            string str;
            Console.Write("Введите число a:");
            str = Console.ReadLine();
            a = int.Parse(str);
            Console.Write("введите число b:");
            str = Console.ReadLine();
            b = int.Parse(str);
            
            //смена значений
            temp = a;
            a = b;
            b = temp;

            //вывод на экран результата работы програииы
            Console.WriteLine($"a = {a}, b = {b}");



            Pause();


        }
    }
}
