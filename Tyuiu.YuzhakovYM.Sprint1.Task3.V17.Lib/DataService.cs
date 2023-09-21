using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YuzhakovYM.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            if ((number * 10) % 10 == 0 | (number * 100) % 10 == 0 | (number * 1000) % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
