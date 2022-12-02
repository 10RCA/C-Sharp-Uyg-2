using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
}
namespace isimalan2
    {
        class Deneme
        {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
        }
    }
class Program
{
    static void Main(string[] args)
    {
        ornek2.Deneme d1 = new ornek2.Deneme();
        isimalan2.Deneme d2 = new isimalan2.Deneme();
        }
}

