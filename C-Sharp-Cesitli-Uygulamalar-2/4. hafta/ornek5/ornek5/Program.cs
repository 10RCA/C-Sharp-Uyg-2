using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ali", "Ahmet", "Selda", "Canan", "Melike" };
            Console.WriteLine("Aranan isim=");
            string aranan = Console.ReadLine();
            foreach (ss in isimler)
            {
                if (aranan.Equals(isimler[0]))
                    Console.WriteLine("Aranan isim bulundu...");
                else Console.WriteLine("İsim yok");
            }
            Console.ReadKey();
        }
    }
}
