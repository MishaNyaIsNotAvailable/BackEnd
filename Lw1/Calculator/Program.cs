using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            while (true)
            {
                Console.Clear();
                calc.InputOperation();
                calc.InputOperands();
                calc.PerformOperation();
                Console.WriteLine("Press anything to repeat");
                Console.ReadLine();
            }
        }
    }
}
