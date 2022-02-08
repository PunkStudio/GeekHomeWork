//задание 2. ввести вес и рост человека. Рассчитаь и вывести индес массы тела по формуле I=m/(h*h),
//m - масса тела в килограммах, h - рост в метрах.
// Степанов Антон
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    class Program
    {
        // пауза в конце выполнения программы
        static private void Pause()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        //расчет индекса массы тела с округлением до двух знаков после запятой
        static private void Index(int weight, double growth)
        {
            double imt; // объявление переменной для округления ответа
            double I = weight / (Math.Pow(growth/100, 2)); // формула расчета с учетом перевода сантиметров в метры
            imt = Math.Round(I,2); // окуругление
            Console.WriteLine($"{imt} is your body mass index");  // вывод сообщения с значением индекса массы тела
            
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Anton Stepanov (C)";
            // объявление переменных
            string str;
            int weight;
            double growth;

            //ввод данных пользователем
            Console.Write("Input ur weight(in kilorgams):");
            str = Console.ReadLine();
            weight = int.Parse(str); //преобразование строки в int
            Console.Write("Input ur growth(in cantimeters):");
            str = Console.ReadLine(); //преобразование строки в int
            growth = double.Parse(str);

            Index(weight, growth);
            Pause();
        }
    }
}
