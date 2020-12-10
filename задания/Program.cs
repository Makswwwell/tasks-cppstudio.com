using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задания
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s;
            Console.WriteLine("введите строку");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine((i + 1) + " элемнет в строке: " + s[i]);
            }
            Console.ReadLine();
        }
    }
}
