using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int value = Convert.ToInt32(number, 16);

            Console.WriteLine(value);

        }
    }
}
