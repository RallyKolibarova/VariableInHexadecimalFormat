using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            double result = 0;

            

            switch (sign)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a, b, result);
                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, result);
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, result);
                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, result);
                    break;
                
            }
        }
    }
}
