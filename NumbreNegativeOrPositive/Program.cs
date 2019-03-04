using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNegativeOrPositive
{
    class Program
    {
        static void PositiveNegative(int operand)
        {
            operand = operand >> 31;
            if (operand == 0)
            {
                Console.WriteLine("Number Positive");
            }
            else
            {
                Console.WriteLine("Number Negative");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write number for check Positive or Negative :");
            int operand = Convert.ToInt32(Console.ReadLine());
                PositiveNegative(operand);

            Console.ReadKey();
        }
    }
}
