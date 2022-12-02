using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek11
{
    /*
     class Program
    {
        static void Metot1(float x, float y)
        { Console.WriteLine("1. metot çağrıldı.");
        }
        static void Metot1(int x, int y)
        { Console.WriteLine("2. metot çağrıldı.");
        }
static void Main(string[] args)
        {
            Metot1('f', 'g');
        }
    }
    */

    class Metotlar
    { static void Metot1(int x, int y, int z)
    { Console.WriteLine("1. metot çağrıldı."); }
    static void Metot1(int x, int y)
    { Console.WriteLine("2. metot çağrıldı."); }
    static void Metot1(float x, int y)
    { Console.WriteLine("3. metot çağrıldı."); }
    static void Main()
    { Metot1(3,3,6);
    Metot1(3.4f,3);
    Metot1(1,'h'); }
    }

}
