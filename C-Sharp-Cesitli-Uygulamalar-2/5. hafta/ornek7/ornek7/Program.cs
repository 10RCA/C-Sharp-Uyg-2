using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek7
{
    class Dortgen
    {
        public int En = 30; public int Boy = 23;
        public int Alan()
        { int Alan = En * Boy; return Alan; }
        static void Main()
        { yaz d1 = new yaz(); d1.Yaz(); }
    }
    class yaz
    {
        public void Yaz()
        {
            Console.WriteLine
            ("En:{0,5}", Dortgen.En);
            Console.WriteLine
            ("Boy:{0,5}", Dortgen.Boy);
            Console.WriteLine
            ("Alan:{0,5}", Dortgen.Alan());
        }
    }
    // özellikler static olarak tanımlanmadığı için hata veriyor. 
    //diğer sınıfta kullanabilmek için static olarak tanımlamak gerekiyor

}
