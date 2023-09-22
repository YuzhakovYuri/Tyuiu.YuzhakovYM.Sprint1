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
            int number1, number2, number3;
            number1 = (int)(number * 10) % 10;
            number2 = (int)(number * 100) % 10;
            number3 = (int)(number * 1000) % 10;
            if (number1 == 0 || number2 == 0 || number3 == 0)
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
