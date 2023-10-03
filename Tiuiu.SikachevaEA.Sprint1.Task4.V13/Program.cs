using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint1.Task4.V13.Lib;

//ЗАДАНИЕ:
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле и печатает его на экране.
//ФОРМУЛА:
//         П
//    COS ---
//         X
//  ------------
//  (3 * e^x + y)
//Ответ округлить до 3-х знаков после запятой 

namespace Tiuiu.SikachevaEA.Sprint1.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("cos(п / 4) / (3 * e^x + y) = " + Math.Round(ds.Calculate(x, y), 3));
            Console.ReadKey();
        }
    }
}
