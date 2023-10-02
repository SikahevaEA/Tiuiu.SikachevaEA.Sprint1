using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint1.Task0.V30.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task0.V30
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
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнила: Сикачёва Елизавета Александровна | РПСб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 20 * 5 - 4             *");
            Console.WriteLine("* и печатает результат на экране.                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 20 * 5 - 4                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadKey();
        }
    }
}
