//программа для расчета расстояний между точками с координатами, которые введет пользователь
//Степанов Антон
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class Program

    { 
        //пауза перед выходом...
        static void Pause()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        // формула расчета расстояния с округлением до двух знаков после запятой
        static void distance(double x1, double x2, double y1,double y2)
        {
            double r;
            r = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F}\n",r);
            
        }
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Anton Stepanov (C)";
            //запрос данных у пользователя
            double x1, x2, y1, y2, r;
            string str;
            Console.Write("Введите координату x первой точки:");
            str = Console.ReadLine();
            x1 = double.Parse(str);
            Console.Write("Введите координату y первой точки:");
            str = Console.ReadLine();
            y1 = double.Parse(str);
            Console.Write("Введите координату x второй точки:");
            str = Console.ReadLine();
            x2 = double.Parse(str);
            Console.Write("Введите координату y второй точки:");
            str = Console.ReadLine();
            y2 = double.Parse(str);
            
            //расчет результата и вывод на экран
            distance(x1,x2,y1,y2);
            //ожидание ввода
            Pause();
        }
    }
}
