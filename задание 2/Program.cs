using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, f, result;
            Console.WriteLine("введите a b f");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
            result = (a + b - f / a) + f * a * a - (a + b);
            Console.WriteLine(" Ответ: " + result);
            Console.ReadLine();


        }
    }
}
