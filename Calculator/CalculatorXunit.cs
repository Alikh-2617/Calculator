using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorXunit
    {

        public int SetInt()
        {
            int x;
            Console.Write(" :>> ");
            //   int x = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("invalid input , try again.");
                Console.WriteLine("invalid input , try again.");
            }
            return x;
        }
        public int sum(int x, int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x-y;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }
        public int div(int x, int y)
        {
            if (x == 0)
            {
                Console.WriteLine("Divid by ziro is invalid ");
                return y;
            }
            if (y == 0)
            {
                Console.WriteLine("Divid by ziro is invalid ");
                return x;
            }
            return x / y;
        }
    }
}
