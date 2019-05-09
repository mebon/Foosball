using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace langirtOyunu
{
    public partial class AnaMenu : Form
    {
        YeniOyun yenioyun;
        Kontroller kontroller;


        public AnaMenu()
        {
            InitializeComponent();
            //ekran boyutunu tam yapma 
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            

        }
        // Butonların Tıklayınca Görevleri
        private void YeniOyun_Click(object sender, EventArgs e)
        {
            yenioyun = new YeniOyun();
            yenioyun.MdiParent = MdiParent;
            yenioyun.Show();

        }
        private void Kontroller_Click(object sender, EventArgs e)
        {
            kontroller = new Kontroller();
            kontroller.MdiParent = MdiParent;
            kontroller.Show();
        }
        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        //ESC-Kapama Tuşu , Enter - Oyun Başlat
        private void AnaMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.Enter)
            {
                yenioyun = new YeniOyun();
                yenioyun.MdiParent = MdiParent;
                yenioyun.Show();
            }
        }
        //Butonların Renk Değiştirmesi
        private void YeniOyun_MouseMove(object sender, MouseEventArgs e)
        {
            YeniOyun.ForeColor = System.Drawing.Color.White;
        }
        private void Kontroller_MouseMove(object sender, MouseEventArgs e)
        {
            Kontroller.ForeColor = System.Drawing.Color.White;
        }
        private void Cikis_MouseMove(object sender, MouseEventArgs e)
        {
            Cikis.ForeColor = System.Drawing.Color.White;
        }
        private void YeniOyun_MouseLeave(object sender, EventArgs e)
        {
            YeniOyun.ForeColor = System.Drawing.Color.Black;
        }
        private void Kontroller_MouseLeave(object sender, EventArgs e)
        {
            Kontroller.ForeColor = System.Drawing.Color.Black;
        }
        private void Cikis_MouseLeave(object sender, EventArgs e)
        {
            Cikis.ForeColor = System.Drawing.Color.Black;
        }
        //
        

    }
}
