﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek8fordongu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, a, n;
            Console.Write("Bir Sayı Girin:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Artım Miktarı:");
            a = Convert.ToInt32(Console.ReadLine());

            for (; i<n;)
            {
                Console.Write("{0}", i);
                i += a;
            }
        }
    }
}
