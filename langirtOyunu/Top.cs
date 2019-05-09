using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace langirtOyunu
{
    public class Top
    {
        //topun koordinatlarını kaydettik ayriyetten topun bir oyuncuya çarpıp çarpmadığını kontrol etmek için kullandık.
        private int xKoordinati;
        private int yKoordinati;
        private PictureBox top;
        
        public Top(int x, int y, PictureBox top)
        {
            xKoordinati = x;
            yKoordinati = y;
            this.top = top;
            
        }
        public int xGetir()
        {
            return xKoordinati + 12;
        }
        public void yenidenBaslat(){
            xKoordinati = 730;
            yKoordinati = 370;
        }
        public int yGetir()
        {
            return yKoordinati + 12;
        }

        public void HareketEttir(int angle)
        {
            int x, y;

            x = Convert.ToInt32(Math.Cos(Math.PI * angle / 180));
            y = Convert.ToInt32(Math.Sin(Math.PI * angle / 180));

            this.xKoordinati += x*3;
            this.yKoordinati += y*3;

            this.top.Location = new Point(this.xKoordinati, this.yKoordinati);
        }

        public bool TopCarpiyorMu(double x1, double y1, double x2, double y2)
        {
            //bütün açıları tarıyorum
            for (int i = 0; i < 360; i++)
            {
                double xTop = Math.Cos(i) + xGetir() + 12;
                double yTop = Math.Sin(i) + yGetir() + 12;

                if (xTop > x1 && xTop < x2 && yTop > y1 && yTop < y2)
                {
                    // Buradan anlaşıldığı üzere topun herhangi bir noktası herhangi bir oyuncuya değmektedir.
                    return true;
                }
            }

            return false;
        }
    }
}
