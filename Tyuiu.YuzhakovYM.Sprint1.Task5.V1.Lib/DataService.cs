using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YuzhakovYM.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double st1 = Math.Abs(x1 - x2);
            double st2 = Math.Abs(y1 - y2);
            double st_res = Math.Sqrt(Math.Pow(st1, 2) + Math.Pow(st2, 2));
            return Convert.ToInt32(st_res);
        }
    }
}
