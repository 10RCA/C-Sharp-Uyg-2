using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek7
{
    class Program
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static int BuyukBul3(int a, int b, int c)
        {
            return BuyukBul(a, BuyukBul(b, c));
        {
                return BuyukBul(a, BuyukBul(b, c));
            }
        }
        static void Main()
        {
            int s1, s2, s3;
            Console.Write("1. Sayıyı Girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı Girin:");
            s3 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk = BuyukBul3(s1, s2, s3);
            Console.WriteLine("En büyük: {0}\'dir.", enbuyuk);


        }
    }
}
