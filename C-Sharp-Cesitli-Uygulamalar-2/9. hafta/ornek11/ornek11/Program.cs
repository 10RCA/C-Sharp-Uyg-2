using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek11
{
    using System.Collections;
    class Koleksiyon : IEnumerable
    {
        int[] Dizi;
        public Koleksiyon(int[] dizi)
        { this.Dizi = dizi; }
        IEnumerator IEnumerable.GetEnumerator()
        { return new ENumaralandırma(this); }
        class ENumaralandırma : IEnumerator //hata veriyor
        {
            int indeks;
            Koleksiyon koleksiyon;
            public ENumaralandırma(Koleksiyon
            koleksiyon)
            {
                this.koleksiyon = koleksiyon;
                indeks = -1;
            }
            public void Reset()
            { indeks = -1; }
        }

    
