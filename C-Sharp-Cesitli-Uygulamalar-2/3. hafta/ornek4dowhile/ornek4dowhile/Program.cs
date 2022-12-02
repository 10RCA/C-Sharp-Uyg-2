using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //döngü kontrol değişkeni
            do
            {
                Console.WriteLine("i = " + i);
                i++;
            } while (i < 0) ;
        }
    }
}
