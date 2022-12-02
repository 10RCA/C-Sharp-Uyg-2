using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek7fordongu
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            for (s = Console.ReadLine(); s != "Çıkış";
                 s = Console.ReadLine())
                Console.WriteLine(s);
        }
    }
}
