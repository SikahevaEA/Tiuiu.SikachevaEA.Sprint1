using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint1.Task3.V5.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.

namespace Tiuiu.SikachevaEA.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 120;
            Console.WriteLine("Масштаб карты = " + x + "(количество км. в одном см.)");
            double y = 3.5;
            Console.WriteLine("Расстояние между точками, изображающими населенные пункты = " + y + "см");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Расстояние между населенными пунктами = " + Math.Round(ds.DistanceLength(x, y), 3));
            Console.ReadKey();
        }
    }
}
