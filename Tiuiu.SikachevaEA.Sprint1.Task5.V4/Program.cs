using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint1.Task5.V4.Lib;

//ЗАДАНИЕ:
//Идет k-я секунда суток. Определить, сколько полных часов (h) прошло к этому
//моменту.

namespace Tiuiu.SikachevaEA.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int k;

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("полных часов прошло" + ds.SecondsToHours(k));
            Console.ReadKey();
        }
    }
}
