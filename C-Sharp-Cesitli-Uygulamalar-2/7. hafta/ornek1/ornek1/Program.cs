using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    class Deneme
    {
        public int a;
        public int b;
        public Deneme(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            ornek1.Deneme d = new ornek1.Deneme(1, 2);
            Console.WriteLine(d.a);
            Console.WriteLine(ornek1.Deneme.Topla(2, 3));
        }
    }
}
