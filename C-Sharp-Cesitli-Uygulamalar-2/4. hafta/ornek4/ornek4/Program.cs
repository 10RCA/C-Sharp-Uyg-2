using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] d = { { 2, 3 }, { 4, 5 }, { 6, 7 } };
            d[2, 1] = 33;
            Console.WriteLine(d.GetValue(2, 1));
            int[][] dd = new int[2][];
            dd[0] = new int[2];
            dd[1] = new int[1];
            dd[0][0] = 23;
            dd[0][1] = 234;
            dd[1][0] = 44;
            Random rn = new Random();
            int[] dizi4 = new int[3];
            dizi4[0] = rn.Next(2, 10);
            dizi4[1] = rn.Next(50);
            dizi[2] = rn.Next();
            Console.WriteLine(dizi.GetValue(2));
            Console.WriteLine(dd[1][0]);
        }
    }
}
