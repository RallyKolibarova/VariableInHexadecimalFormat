using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                char elem = (char)n;
                word += elem;
                
            }
            Console.WriteLine(word);
        }
    }
}
