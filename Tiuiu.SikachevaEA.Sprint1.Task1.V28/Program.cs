using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint1.Task1.V28.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #0 | Выполнила: Сикачёва Е. А. | РПСб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема : Базовые насвыки работы в С#                                     *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #28                                                            *");
            Console.WriteLine("* Выполнила: Сикачёва Елизавета Александровна | РПСб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* вычисляет результат по формуле (x*2)/(1+x) и печатает его на экране.   *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
