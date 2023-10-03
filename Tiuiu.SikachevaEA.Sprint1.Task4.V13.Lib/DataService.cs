using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tiuiu.SikachevaEA.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            if (Math.Cos(Math.PI / x) == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return 0;
            }
            else
            {
                var res = Math.Cos(Math.PI / x) / (3 * Math.Pow(Math.E, x + y));
                return res;
            }
        }
    }
}
