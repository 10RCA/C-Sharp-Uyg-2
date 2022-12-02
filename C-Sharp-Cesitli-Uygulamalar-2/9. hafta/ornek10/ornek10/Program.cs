using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek10
{
    class
 A
    {
        public int OzellikA
      ;
        public A(int a)
        { OzellikA = a; }
    }
    class B : A
    {
        public int OzellikB
      ;
        public B(int b, int a) : base(a)
        { OzellikB = b; }
    }
    class C : B
    {
        public int OzellikC
      ;
        public C(int c, int b, int a) : base
        (b, a
        )
        { OzellikC = c; }
        static void Main()
        {
            C nesne = new C(12, 56, 23);
            Console.WriteLine
            (nesne.OzellikA + " "+nesne.OzellikB+" "+nesne.OzellikC);
        }
    } }