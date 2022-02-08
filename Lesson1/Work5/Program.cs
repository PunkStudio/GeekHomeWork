// программ, которая выводит на экран имя, фамилию и город проживания на экран(собственные методы, вывод в центре)
// Степанов Антон
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work5
{
    class Program
    {
        static void MyScreen(int left, int top)
        {
            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50, 20);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.Title = "Anton Stepanov (C)";
            
        }
        static void Pause()
        {
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void Print(string name, string surname, string city)
        {
            Console.WriteLine($"Задание выполнил: {name} {surname}.");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine($"{city}");
        }
        static void Main(string[] args)
        {
            MyScreen(10,10);
            string name, surname, city;
            name = "Антон";
            surname = "Степанов";
            city = "Ленинградская область, город Выборг";
            Print(name, surname,city);


            Pause();

        }
    }
}
