using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace langirtOyunu
{
    public partial class YeniOyun : Form
    {
        AnaMenu anamenu;
        
        public int skor1 = 0, skor2 = 0 ;

        public Oyuncu[] Oyuncular;
        public Top ball;

        private int angle = 60;

        public YeniOyun()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Cursor.Hide();

            timer1.Enabled = true;
            //oyuncuların koordinatlarını kaydettik.
            Oyuncular = new Oyuncu[22];
            
            Oyuncular[0] = new Oyuncu(o1k.Location.X, o1k.Location.Y);
            Oyuncular[1] = new Oyuncu(o1d1.Location.X, o1d1.Location.Y);
            Oyuncular[2] = new Oyuncu(o1d2.Location.X, o1d2.Location.Y);
            Oyuncular[3] = new Oyuncu(o1d3.Location.X, o1d3.Location.Y);
            Oyuncular[4] = new Oyuncu(o1o1.Location.X, o1o1.Location.Y);
            Oyuncular[5] = new Oyuncu(o1o2.Location.X, o1o2.Location.Y);
            Oyuncular[6] = new Oyuncu(o1o3.Location.X, o1o3.Location.Y);
            Oyuncular[7] = new Oyuncu(o1o4.Location.X, o1o4.Location.Y);
            Oyuncular[8] = new Oyuncu(o1f1.Location.X, o1f1.Location.Y);
            Oyuncular[9] = new Oyuncu(o1f2.Location.X, o1f2.Location.Y);
            Oyuncular[10] = new Oyuncu(o1f3.Location.X, o1f3.Location.Y);
            Oyuncular[11] = new Oyuncu(o2k.Location.X, o2k.Location.Y);
            Oyuncular[12] = new Oyuncu(o2d1.Location.X, o2d1.Location.Y);
            Oyuncular[13] = new Oyuncu(o2d2.Location.X, o2d2.Location.Y);
            Oyuncular[14] = new Oyuncu(o2d3.Location.X, o2d3.Location.Y);
            Oyuncular[15] = new Oyuncu(o2o1.Location.X, o2o1.Location.Y);
            Oyuncular[16] = new Oyuncu(o2o2.Location.X, o2o2.Location.Y);
            Oyuncular[17] = new Oyuncu(o2o3.Location.X, o2o3.Location.Y);
            Oyuncular[18] = new Oyuncu(o2o4.Location.X, o2o4.Location.Y);
            Oyuncular[19] = new Oyuncu(o2f1.Location.X, o2f1.Location.Y);
            Oyuncular[20] = new Oyuncu(o2f2.Location.X, o2f2.Location.Y);
            Oyuncular[21] = new Oyuncu(o2f3.Location.X, o2f3.Location.Y);

            ball = new Top(top.Location.X, top.Location.Y, top);
        }
        bool q, a, w, s, ee, d, r, f, y, h, u, j, ı, k, o, l;
        //Oyunu Gizle ve Tuşlara Basılınca Yapılacaklar
        private void YeniOyun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Show();
                this.Close();
            } //Oyunu kapat
            if (e.KeyCode == Keys.Enter)
            {
                ball.yenidenBaslat();
                skor2 = 0;
                skor1 = 0;
                oyuncu1skor.Text = skor1.ToString();
                oyuncu2skor.Text = skor2.ToString();

            }

            //Oyuncu 1 Tuşları
            if (e.KeyCode == Keys.Q) q = true; 
            if (e.KeyCode == Keys.A) a = true;
            if (e.KeyCode == Keys.W) w = true;
            if (e.KeyCode == Keys.S) s = true;
            if (e.KeyCode == Keys.E) ee = true;
            if (e.KeyCode == Keys.D) d = true;
            if (e.KeyCode == Keys.R) r = true;
            if (e.KeyCode == Keys.F) f = true;

             
            //Oyuncu 1 Tuş Görevleri
            //Kaleci 1
            if (o1k.Top <= 425 && o1k.Top >= 250)
            {
                if (q == true)
                {
                    o1k.Top -= 1;                                                   //Kaleci görüntü yukarı
                    Oyuncular[0].hareketEttir(Oyuncular[0].yGetir() - 1);           //Kaleci yukarı 
                }
                if (a == true)
                {
                    o1k.Top += 1;                                                   //Kaleci görüntü aşağı
                    Oyuncular[0].hareketEttir(Oyuncular[0].yGetir() + 1);           //Kaleci aşagı   
                }
            }
            else //Oyuncu sınırdan çıkarsa
            {

                if (o1k.Top >= 425)
                {
                    o1k.Top -= 3;
                    Oyuncular[0].hareketEttir(Oyuncular[0].yGetir() - 3);
                }
                if (o1k.Top <= 250)
                {
                    o1k.Top += 3;
                    Oyuncular[0].hareketEttir(Oyuncular[0].yGetir() + 3);
                }
            }


            //Defans 1
            if (o1d1.Top >= 0 && o1d3.Top <= 675)
            {
                if (w == true) { 
                    o1d1.Top -= 2;
                    o1d2.Top -= 2; 
                    o1d3.Top -= 2;
                    Oyuncular[1].hareketEttir(Oyuncular[1].yGetir() - 2);
                    Oyuncular[2].hareketEttir(Oyuncular[2].yGetir() - 2);
                    Oyuncular[3].hareketEttir(Oyuncular[3].yGetir() - 2);
                }; //Defans yukarı
                if (s == true) { 
                    o1d1.Top += 2;
                    o1d2.Top += 2; 
                    o1d3.Top += 2;
                    Oyuncular[1].hareketEttir(Oyuncular[1].yGetir() + 2);
                    Oyuncular[2].hareketEttir(Oyuncular[2].yGetir() + 2);
                    Oyuncular[3].hareketEttir(Oyuncular[3].yGetir() + 2);
                }; //Defans aşağı
                
            }

            else//Oyuncular sınırdan çıkarsa
            {
                if (o1d1.Top <= 0)
                {
                    o1d1.Top += 5;
                    o1d2.Top += 5;
                    o1d3.Top += 5;
                    Oyuncular[1].hareketEttir(Oyuncular[1].yGetir() + 5);
                    Oyuncular[2].hareketEttir(Oyuncular[2].yGetir() + 5);
                    Oyuncular[3].hareketEttir(Oyuncular[3].yGetir() + 5);
                }
                if (o1d3.Top >= 675)
                {
                    o1d1.Top -= 5;
                    o1d2.Top -= 5;
                    o1d3.Top -= 5;
                    Oyuncular[1].hareketEttir(Oyuncular[1].yGetir() - 5);
                    Oyuncular[2].hareketEttir(Oyuncular[2].yGetir() - 5);
                    Oyuncular[3].hareketEttir(Oyuncular[3].yGetir() - 5);
                }
            }


            //Ortasaha 1 
            if (o1o1.Top >= 0 && o1o4.Top <= 675)
            {
                if (ee == true) { 
                    o1o1.Top -= 2; 
                    o1o2.Top -= 2; 
                    o1o3.Top -= 2; 
                    o1o4.Top -= 2;
                    Oyuncular[4].hareketEttir(Oyuncular[4].yGetir() - 2);
                    Oyuncular[5].hareketEttir(Oyuncular[5].yGetir() - 2);
                    Oyuncular[6].hareketEttir(Oyuncular[6].yGetir() - 2); 
                    Oyuncular[7].hareketEttir(Oyuncular[7].yGetir() - 2);
                }; //Ortasaha yukarı
                if (d == true) { 
                    o1o1.Top += 2;
                    o1o2.Top += 2; 
                    o1o3.Top += 2; 
                    o1o4.Top += 2;
                    Oyuncular[4].hareketEttir(Oyuncular[4].yGetir() + 2);
                    Oyuncular[5].hareketEttir(Oyuncular[5].yGetir() + 2);
                    Oyuncular[6].hareketEttir(Oyuncular[6].yGetir() + 2);
                    Oyuncular[7].hareketEttir(Oyuncular[7].yGetir() + 2);
                }; //Ortasaha aşağı
            }

            else
            {
                if (o1o1.Top <= 0)
                {
                    o1o1.Top += 5;
                    o1o2.Top += 5;
                    o1o3.Top += 5;
                    o1o4.Top += 5;
                    Oyuncular[4].hareketEttir(Oyuncular[4].yGetir() + 5);
                    Oyuncular[5].hareketEttir(Oyuncular[5].yGetir() + 5);
                    Oyuncular[6].hareketEttir(Oyuncular[6].yGetir() + 5);
                    Oyuncular[7].hareketEttir(Oyuncular[7].yGetir() + 5);
                } 
                if (o1o4.Top >= 675)
                {
                    o1o1.Top -= 5;
                    o1o2.Top -= 5;
                    o1o3.Top -= 5;
                    o1o4.Top -= 5;
                    Oyuncular[4].hareketEttir(Oyuncular[4].yGetir() - 5);
                    Oyuncular[5].hareketEttir(Oyuncular[5].yGetir() - 5);
                    Oyuncular[6].hareketEttir(Oyuncular[6].yGetir() - 5);
                    Oyuncular[7].hareketEttir(Oyuncular[7].yGetir() - 5);
                }
            }


            //Forvet 1
            if (o1f1.Top >= 0 && o1f3.Top <= 675)
            {
                if (r == true) { 
                    o1f1.Top -= 2; 
                    o1f2.Top -= 2; 
                    o1f3.Top -= 2;
                    Oyuncular[8].hareketEttir(Oyuncular[8].yGetir() - 2);
                    Oyuncular[9].hareketEttir(Oyuncular[9].yGetir() - 2);
                    Oyuncular[10].hareketEttir(Oyuncular[10].yGetir() - 2);
                }; //Forvet yukarı
                if (f == true) { 
                    o1f1.Top += 2;
                    o1f2.Top += 2; 
                    o1f3.Top += 2;
                    Oyuncular[8].hareketEttir(Oyuncular[8].yGetir() + 2);
                    Oyuncular[9].hareketEttir(Oyuncular[9].yGetir() + 2);
                    Oyuncular[10].hareketEttir(Oyuncular[10].yGetir() + 2);
                }; //Forvet aşağı
            }
            else
            {
                if (o1f1.Top <= 0)
                {
                    o1f1.Top += 5;
                    o1f2.Top += 5;
                    o1f3.Top += 5;
                    Oyuncular[8].hareketEttir(Oyuncular[8].yGetir() + 5);
                    Oyuncular[9].hareketEttir(Oyuncular[9].yGetir() + 5);
                    Oyuncular[10].hareketEttir(Oyuncular[10].yGetir() + 5);
                } 
                if (o1f3.Top >= 675)
                {
                    o1f1.Top -= 5;
                    o1f2.Top -= 5;
                    o1f3.Top -= 5;
                    Oyuncular[8].hareketEttir(Oyuncular[8].yGetir() - 5);
                    Oyuncular[9].hareketEttir(Oyuncular[9].yGetir() - 5);
                    Oyuncular[10].hareketEttir(Oyuncular[10].yGetir() - 5);
                }
            }
            

            //Oyuncu 2 Tuşları
            if (e.KeyCode == Keys.Y) y = true;
            if (e.KeyCode == Keys.H) h = true;
            if (e.KeyCode == Keys.U) u = true;
            if (e.KeyCode == Keys.J) j = true;
            if (e.KeyCode == Keys.I) ı = true;
            if (e.KeyCode == Keys.K) k = true;
            if (e.KeyCode == Keys.O) o = true;
            if (e.KeyCode == Keys.L) l = true;

            //Oyuncu 2 görevleri
            //Oyuncu 1 Tuş Görevleri
            //Kaleci 1
            if (o2k.Top <= 425 && o2k.Top >= 250)
            {
                if (o == true)
                {
                    o2k.Top -= 1;
                    Oyuncular[11].hareketEttir(Oyuncular[11].yGetir() - 1);
                    
                };//Kaleci yukarı
                if (l == true)
                {
                    o2k.Top += 1;
                    Oyuncular[11].hareketEttir(Oyuncular[11].yGetir() + 1);
                };//Kaleci aşağı
            }
            else
            {
                if (o2k.Top >= 425)
                {
                    o2k.Top -= 3;
                    Oyuncular[11].hareketEttir(Oyuncular[11].yGetir() - 3);
                }
                if (o2k.Top <= 250)
                {
                    o2k.Top += 3;
                    Oyuncular[11].hareketEttir(Oyuncular[11].yGetir() + 3);
                }
            }


            //Defans 1
            if (o2d1.Top >= 0 && o2d3.Top <= 675)
            {
                if (ı == true) { 
                    o2d1.Top -= 2; 
                    o2d2.Top -= 2; 
                    o2d3.Top -= 2;
                    Oyuncular[12].hareketEttir(Oyuncular[12].yGetir() - 2);
                    Oyuncular[13].hareketEttir(Oyuncular[13].yGetir() - 2);
                    Oyuncular[14].hareketEttir(Oyuncular[14].yGetir() - 2);
                }; //Defans yukarı
                if (k == true) { 
                    o2d1.Top += 2; 
                    o2d2.Top += 2; 
                    o2d3.Top += 2;
                    Oyuncular[12].hareketEttir(Oyuncular[12].yGetir() + 2);
                    Oyuncular[13].hareketEttir(Oyuncular[13].yGetir() + 2);
                    Oyuncular[14].hareketEttir(Oyuncular[14].yGetir() + 2);
                }; //Defans aşağı
            }
            else
            {
                if (o2d1.Top <= 0)
                {
                    o2d1.Top += 5;
                    o2d2.Top += 5;
                    o2d3.Top += 5;
                    Oyuncular[12].hareketEttir(Oyuncular[12].yGetir() + 5);
                    Oyuncular[13].hareketEttir(Oyuncular[13].yGetir() + 5);
                    Oyuncular[14].hareketEttir(Oyuncular[14].yGetir() + 5);
                }
                if (o2d3.Top >= 675)
                {
                    o2d1.Top -= 5;
                    o2d2.Top -= 5;
                    o2d3.Top -= 5;
                    Oyuncular[12].hareketEttir(Oyuncular[12].yGetir() - 5);
                    Oyuncular[13].hareketEttir(Oyuncular[13].yGetir() - 5);
                    Oyuncular[14].hareketEttir(Oyuncular[14].yGetir() - 5);
                }
            }


            //Ortasaha 1 
            if (o2o1.Top >= 0 && o2o4.Top <= 675)
            {
                if (u == true) { 
                    o2o1.Top -= 2; 
                    o2o2.Top -= 2;
                    o2o3.Top -= 2; 
                    o2o4.Top -= 2;
                    Oyuncular[15].hareketEttir(Oyuncular[15].yGetir() - 2);
                    Oyuncular[16].hareketEttir(Oyuncular[16].yGetir() - 2);
                    Oyuncular[17].hareketEttir(Oyuncular[17].yGetir() - 2);
                    Oyuncular[18].hareketEttir(Oyuncular[18].yGetir() - 2);
                }; //Ortasaha yukarı
                if (j == true) { 
                    o2o1.Top += 2; 
                    o2o2.Top += 2; 
                    o2o3.Top += 2; 
                    o2o4.Top += 2;
                    Oyuncular[15].hareketEttir(Oyuncular[15].yGetir() + 2);
                    Oyuncular[16].hareketEttir(Oyuncular[16].yGetir() + 2);
                    Oyuncular[17].hareketEttir(Oyuncular[17].yGetir() + 2);
                    Oyuncular[18].hareketEttir(Oyuncular[18].yGetir() + 2);
                }; //Ortasaha aşağı
            }
            else
            {
                if (o2o1.Top <= 0)
                {
                    o2o1.Top += 5;
                    o2o2.Top += 5;
                    o2o3.Top += 5;
                    o2o4.Top += 5;
                    Oyuncular[15].hareketEttir(Oyuncular[15].yGetir() + 5);
                    Oyuncular[16].hareketEttir(Oyuncular[16].yGetir() + 5);
                    Oyuncular[17].hareketEttir(Oyuncular[17].yGetir() + 5);
                    Oyuncular[18].hareketEttir(Oyuncular[18].yGetir() + 5);
                }
                if (o2o4.Top >= 675)
                {
                    o2o1.Top -= 5;
                    o2o2.Top -= 5;
                    o2o3.Top -= 5;
                    o2o4.Top -= 5;
                    Oyuncular[15].hareketEttir(Oyuncular[15].yGetir() - 5);
                    Oyuncular[16].hareketEttir(Oyuncular[16].yGetir() - 5);
                    Oyuncular[17].hareketEttir(Oyuncular[17].yGetir() - 5);
                    Oyuncular[18].hareketEttir(Oyuncular[18].yGetir() - 5);
                }
            }


            //Forvet 1
            if (o2f1.Top >= 0 && o2f3.Top <= 675)
            {
                if (y == true) { 
                    o2f1.Top -= 2;
                    o2f2.Top -= 2;
                    o2f3.Top -= 2;
                    Oyuncular[19].hareketEttir(Oyuncular[19].yGetir() - 2);
                    Oyuncular[20].hareketEttir(Oyuncular[20].yGetir() - 2);
                    Oyuncular[21].hareketEttir(Oyuncular[21].yGetir() - 2);
                }; //Forvet yukarı
                if (h == true) { 
                    o2f1.Top += 2;
                    o2f2.Top += 2; 
                    o2f3.Top += 2;
                    Oyuncular[19].hareketEttir(Oyuncular[19].yGetir() + 2);
                    Oyuncular[20].hareketEttir(Oyuncular[20].yGetir() + 2);
                    Oyuncular[21].hareketEttir(Oyuncular[21].yGetir() + 2);
                }; //Forvet aşağı
            }
            else
            {
                if (o2f1.Top <= 0)
                {
                    o2f1.Top += 5;
                    o2f2.Top += 5;
                    o2f3.Top += 5;
                    Oyuncular[19].hareketEttir(Oyuncular[19].yGetir() + 5);
                    Oyuncular[20].hareketEttir(Oyuncular[20].yGetir() + 5);
                    Oyuncular[21].hareketEttir(Oyuncular[21].yGetir() + 5);
                }
                if (o2f3.Top >= 675)
                {
                    o2f1.Top -= 5;
                    o2f2.Top -= 5;
                    o2f3.Top -= 5;
                    Oyuncular[19].hareketEttir(Oyuncular[19].yGetir() - 5);
                    Oyuncular[20].hareketEttir(Oyuncular[20].yGetir() - 5);
                    Oyuncular[21].hareketEttir(Oyuncular[21].yGetir() - 5);
                }
            }

        }
        //Tuşa Basılı Tutmayı Bırakınca Yapılacaklar
        private void YeniOyun_KeyUp(object sender, KeyEventArgs e)
        {
            //Oyuncu 1 Tuşları
            if (e.KeyCode == Keys.Q) q = false;
            if (e.KeyCode == Keys.A) a = false;
            if (e.KeyCode == Keys.W) w = false;
            if (e.KeyCode == Keys.S) s = false;
            if (e.KeyCode == Keys.E) ee = false;
            if (e.KeyCode == Keys.D) d = false;
            if (e.KeyCode == Keys.R) r = false;
            if (e.KeyCode == Keys.F) f = false;

            //Oyuncu 2 Tuşları
            if (e.KeyCode == Keys.Y) y = false;
            if (e.KeyCode == Keys.H) h = false;
            if (e.KeyCode == Keys.U) u = false;
            if (e.KeyCode == Keys.J) j = false;
            if (e.KeyCode == Keys.I) ı = false;
            if (e.KeyCode == Keys.K) k = false;
            if (e.KeyCode == Keys.O) o = false;
            if (e.KeyCode == Keys.L) l = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //topu belli bir açıyla hareket ettiriyorum başlangıçta 60 olarak belirledik.
            ball.HareketEttir(angle);

            foreach(Oyuncu o in Oyuncular) {
                //foreach = oyuncular dizisinin içindeki her bir oyuncu için.

                //oyuncunun sınırları
                double oyuncuXLeft, oyuncuXRight, oyuncuYTop, oyuncuYBottom;

                oyuncuXLeft = o.xGetir() - 38;
                oyuncuXRight = o.xGetir() + 38;
                oyuncuYTop = o.yGetir() - 25;
                oyuncuYBottom = o.yGetir() + 25;
                //oyuncunun kaplamış olduğu alanı işgal ediyor mu ? topun herhangi bir noktası
                if (ball.TopCarpiyorMu(oyuncuXLeft, oyuncuYTop, oyuncuXRight, oyuncuYBottom))
                {
                    // Buradan anlaşıldığı üzere topun herhangi bir noktası herhangi bir oyuncuya değmektedir.
                    Random rnd = new Random();
                    angle = rnd.Next(1, 23) * 15;
                    //15 ve katları şeklinde açılarla hareket etmesini istedik.
                }
            }
            //Oyun alanı sınırları
            if (top.Left <= oyunAlani.Left || top.Right >= oyunAlani.Right)
            {
                Random rnd = new Random();
                angle = rnd.Next(1, 23) * 15;
            }
            if (top.Bottom >= oyunAlani.Bottom || top.Top <= oyunAlani.Top)
            {
                angle *= -1;
            }

            
        //Gol Durumu 
            if (ball.TopCarpiyorMu(kale1.Left, kale1.Top, kale1.Right, kale1.Bottom))
            {      
                skor2 = Int32.Parse(oyuncu2skor.Text);
                skor2++;
                oyuncu2skor.Text = skor2.ToString();

                angle += 90;
                ball.yenidenBaslat();

            } 
            if (ball.TopCarpiyorMu(kale2.Left, kale2.Top, kale2.Right, kale2.Bottom))
            {
                skor1 = Int32.Parse(oyuncu1skor.Text);
                skor1++;
                oyuncu1skor.Text = skor1.ToString();

                angle += 90;
                ball.yenidenBaslat();
                
            }
                
                
            
        

        }
    }
}
