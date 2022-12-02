using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    public class Silecek : UrunTemel
    {
        private int uzunluk;
        public Silecek(int kodu, double fiyat,
       string bilgi) : base(kodu, fiyat, bilgi)
        {
        }
        public int Uzunluk
        {
            get { return uzunluk; }
            set { uzunluk = value; }
        }
        public override string ToString()
        {
            return UrunKodu.ToString() + " " +
           BirimFiyat.ToString() + " " + UrunTanimi +
           " " + Uzunluk.ToString();
        }
    }    public class Urunler<T> where T : UrunTemel
    {
        private List<T> urunListe;
        public Urunler()
        {
            urunListe = new List<T>();
        }
        public void Ekle(T uye)
        {
            urunListe.Add(uye);
        }
        public void Sil(T uye)
        {
            urunListe.Remove(uye);
        }
        public void Listele()
        {
            foreach (T uye in urunListe)
            {

                Console.WriteLine(uye.ToString());
            }
        }
    }
    class Ana
    {
        static void Main()
        {
            Urunler<UrunTemel> urunler = new Urunler<UrunTemel>();
            Lastik lst = new Lastik(1000, 10,
           "Otomobil Lastiği");
            lst.Tip = "Kış Lastiği";
            lst.Cap = 185;
            lst.Genislik = 75;
            Silecek slc = new Silecek(1001, 5,
           "On silecek takimi");
            slc.Uzunluk = 60;
            urunler.Ekle(lst);
            urunler.Ekle(slc);
            urunler.Listele();
        }
    }
}
