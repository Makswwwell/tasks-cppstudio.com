using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, km;
            int s;  
            Console.WriteLine("Введите значение: 1 - метры в километры \t 2 - километры в метры");
            s = int.Parse(Console.ReadLine());
            switch (s)
            {
                case 1:
                    m = double.Parse(Console.ReadLine());
                    Console.WriteLine("метры в километры");
                    Console.WriteLine(km = 1000 * m);
                    break;
                case 2:
                    km = double.Parse(Console.ReadLine());
                    Console.WriteLine("километры в метры");
                    Console.WriteLine(m = km / 1000);
                    break;

            }
            Console.ReadLine();
        }
    }
}
