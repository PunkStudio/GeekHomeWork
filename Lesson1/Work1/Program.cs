/* программа анкета. Запрос имени, фамилии, возраста, роста и веса
 Результат выаодится в одну строку
 используя склеивание
 форматированный вывод
 вывод со знаком $

Степанов Антон
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Anton Stepanov (C)";
            Console.Write("Hi! Enter ur name:");
            string name = Console.ReadLine();
            Console.Write("Hi! Enter ur surname:");
            string surname = Console.ReadLine();
            Console.Write("Hi! Enter ur age:");
            string age = Console.ReadLine();
            Console.Write("Hi! Enter ur growth(in centimetrs):");
            string growth = Console.ReadLine();
            Console.Write("Hi! Enter ur weight(in kilorgams):");
            string weight = Console.ReadLine();

            Console.WriteLine(name + " " + surname + ", " + age + " years old, " + growth + "cm, " + weight + "kg");
            Console.WriteLine("{0} {1}, {2} years old, {3}cm, {4}kg", name, surname, age, growth, weight);
            Console.WriteLine($"{name} {surname}, {age} years old, {growth}cm, {weight}kg");

            Console.Write("Press any key... ");
            Console.ReadKey();
        }
    }
}
