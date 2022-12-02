using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            model1 otol new model1();
            model2 oto2 new model2();
            oto1.tur ="Sedan";
            otol.silindir_sayisi = 4;
            otol.subap_sayisi = 8;
            otol.guc = 75;
            otol.tork = 100;
            otol.ozellikyaz();
            Console.WriteLine("*******");
            oto2.model2_boy = 6;
            oto2.model2_agirlik= 900;
            oto2.model2_renk = "kırmızı";
            oto2.ozellikyaz();
            Console.WriteLine("*****");
            oto2.goster();
            Console.ReadLine();
            Console.WriteLine("*****");
            otol.goster();
            Console.ReadLine();
        }
    }
}
