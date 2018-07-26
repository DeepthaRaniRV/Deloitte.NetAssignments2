using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void print(int num);
        static void Main(string[] args)
        {
            Printing p = new Printing();
            print p1 = p.printNumber;
            p1 += p.printMoney;
            p1 += p.hexaDecimal;

            p1(100000);
        }
    }
}
