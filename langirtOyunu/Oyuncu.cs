using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langirtOyunu
{
    public class Oyuncu
    {
        //oyuncunun x y koordinatlarını kaydettğimiz aynı zmanada hareket ettireceğimiz bir sınıf oluşturduk.
        private int xKoordinati;
        private int yKoordinati;

        public static int genislik = 76;
        public static int yukseklik = 50;

        public Oyuncu(int x, int y)
        {
            xKoordinati = x;
            yKoordinati = y;
        }

        public void hareketEttir(int yeniY)
        {
            this.yKoordinati = yeniY - yukseklik / 2;
        }

        public int xGetir()
        {
            return this.xKoordinati + genislik / 2;
        }

        public int yGetir()
        {
            return this.yKoordinati + yukseklik / 2;
        }
    }
}
