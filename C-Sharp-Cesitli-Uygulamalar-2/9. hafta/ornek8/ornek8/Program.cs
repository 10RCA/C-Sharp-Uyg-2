using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek8
{
    class Program
    {
        class A
        {
            public void Metot1()
            { Metot2(); }
            public void Metot2()
            { Console.WriteLine("A sınıfı"); }
        }
        class B : A
        {
            public new void Metot1()
            { Metot2(); }
            public new void Metot2()
            { Console.WriteLine("B sınıfı"); }
        }
        class Ana
        {
            static void Main()
            {
                B b = new B();
                b.Metot1();
            }
        }
    }
}
