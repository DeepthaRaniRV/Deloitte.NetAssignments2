using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Printing
    {
        public void printNumber(int num)
        {
            
            Console.WriteLine("The number format is "+ string.Format("{0:n0}", num));
        }
        public void printMoney(int num)
        {
            double value = num;
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
        }
        public void hexaDecimal(int num)
        {

            Console.WriteLine(String.Format("{0:X4} - This is hexadecimal number = ",num));
        }
    }
}
