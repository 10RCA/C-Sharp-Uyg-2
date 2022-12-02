using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    delegate void OlayYoneticisi();
    class deneme
    {
        OlayYoneticisi[] evnt = new OlayYoneticisi[3];
        public int i = 0; public int j = 0;
        public event OlayYoneticisi Olay
        {
            add
            {
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    Console.WriteLine((i + 1) + ". Olay");
                }
                i++;
                if (i == 3)
                { --i; Console.WriteLine("Olay listesi Dolu"); }
            }
            remove
            {
                Console.WriteLine(i);
                {
                    if (evnt[i] == value)
                    {
                        evnt[i] = null;
                        Console.WriteLine(" Olay çıkarıldı.");
                    }
                    i--;
                    if (i == -1)
                        Console.WriteLine("Olay bulunamadı");
                }
            }
        }
    }
}
