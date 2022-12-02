using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek10
{
    /* class Program
     {
         static void Metot1(float x, float y)
         { Console.WriteLine("1. metot çağrıldı.");
         }
         static void Metot1(double x, double y)
         { Console.WriteLine("2. metot çağrıldı.");
         }

 static void Main(string[] args)
         {
             Metot1(5, 6);
         }
     }
     */
    class Metotlar
    { static void Metot1(float x, float y)
    { Console.WriteLine("1. metot çağrıldı.");
    }
      static void Metot1(int x, int y)
      { Console.WriteLine("2. metot çağrıldı.");
    }
    static void Main()
    { Metot1(5,6.4f); }
    }

}
