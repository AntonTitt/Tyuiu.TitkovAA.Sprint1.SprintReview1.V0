using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint1.SprintReview1.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.SprintReview1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dt = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #8                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до 3 *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите 1 число: ");
            double x,y,z;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            z = dt.Calculate(x, y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
