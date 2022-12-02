using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace ornek9
    {
        class Topla
        {
            public int tpl;
            public Topla(int toplam)
            { tpl = toplam; }
            public int Toplama
            {
                get { return tpl; } // değeri görüntüleme
                set { tpl = value + tpl; } // yeni değeri depola
            }

            static void Main(string[] args)
            {
                Topla ekle = new Topla(0);
                Console.WriteLine("Başlangıç değeri->" + ekle.Toplama);
                for (int i = 1; i < 100; i++) ekle.Toplama = i;
                Console.WriteLine("Sayıların toplamı" + ekle.Toplama);
            }
        }
    }


