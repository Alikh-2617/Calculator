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
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("invalid input , try again.");
                Console.WriteLine("invalid input , try again.");
            }
            return x;
        }
        public int[] SetList()
        {
            Console.Write(" :>> ");
            int[] x = { };
            for (int i = 0; i < 10; i++) { Console.Write(" :>> "); x[i] = Convert.ToInt32(Console.ReadLine()); }
            return x;
        }
        public int sum(int x, int y)
        {
            return x + y;
        }
        public int sum(int[] x , int[]  y)
        {
            return x[0] + y[0];
        }
        public int sub(int x, int y)
        {
            return x-y;
        }
        public int sub(int[] x, int[] y)
        {
            return x[0] - y[0];
        }

        public int mul(int x, int y)
        {
            return x * y;
        }
        public void div(int x , int y)
        {

            try
            {
                Console.WriteLine("Svart : " + x / y);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Just Catched Exception with e : {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("It just finallt block , Reject it ");
            //}
        }


        //public int div(int x, int y)
        //{
        //    if (x == 0)
        //    {
        //        Console.WriteLine("Divid by ziro is invalid ");
        //        return y;
        //    }
        //    if (y == 0)
        //    {
        //        Console.WriteLine("Divid by ziro is invalid ");
        //        return x;
        //    }
        //    return x / y;
        //}

    }
}
