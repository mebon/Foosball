namespace langirtOyunu
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.AnaMenuPanel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.Cikis = new System.Windows.Forms.Label();
            this.Kontroller = new System.Windows.Forms.Label();
            this.YeniOyun = new System.Windows.Forms.Label();
            this.AnaMenuPanel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaMenuPanel
            // 
            this.AnaMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnaMenuPanel.BackgroundImage")));
            this.AnaMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnaMenuPanel.Controls.Add(this.menu);
            this.AnaMenuPanel.Location = new System.Drawing.Point(0, -3);
            this.AnaMenuPanel.Name = "AnaMenuPanel";
            this.AnaMenuPanel.Size = new System.Drawing.Size(2053, 1068);
            this.AnaMenuPanel.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Controls.Add(this.Cikis);
            this.menu.Controls.Add(this.Kontroller);
            this.menu.Controls.Add(this.YeniOyun);
            this.menu.Location = new System.Drawing.Point(785, 219);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(500, 650);
            this.menu.TabIndex = 0;
            // 
            // Cikis
            // 
            this.Cikis.AutoSize = true;
            this.Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cikis.Font = new System.Drawing.Font("Segoe Marker", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cikis.Location = new System.Drawing.Point(147, 527);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(188, 93);
            this.Cikis.TabIndex = 2;
            this.Cikis.Text = "Çıkış";
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            this.Cikis.MouseLeave += new System.EventHandler(this.Cikis_MouseLeave);
            this.Cikis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cikis_MouseMove);
            // 
            // Kontroller
            // 
            this.Kontroller.AutoSize = true;
            this.Kontroller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kontroller.Font = new System.Drawing.Font("Segoe Marker", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kontroller.Location = new System.Drawing.Point(82, 271);
            this.Kontroller.Name = "Kontroller";
            this.Kontroller.Size = new System.Drawing.Size(341, 93);
            this.Kontroller.TabIndex = 1;
            this.Kontroller.Text = "Kontroller";
            this.Kontroller.Click += new System.EventHandler(this.Kontroller_Click);
            this.Kontroller.MouseLeave += new System.EventHandler(this.Kontroller_MouseLeave);
            this.Kontroller.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Kontroller_MouseMove);
            // 
            // YeniOyun
            // 
            this.YeniOyun.AutoSize = true;
            this.YeniOyun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YeniOyun.Font = new System.Drawing.Font("Segoe Marker", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeniOyun.Location = new System.Drawing.Point(80, -11);
            this.YeniOyun.Name = "YeniOyun";
            this.YeniOyun.Size = new System.Drawing.Size(342, 93);
            this.YeniOyun.TabIndex = 0;
            this.YeniOyun.Text = "Yeni Oyun";
            this.YeniOyun.Click += new System.EventHandler(this.YeniOyun_Click);
            this.YeniOyun.MouseLeave += new System.EventHandler(this.YeniOyun_MouseLeave);
            this.YeniOyun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YeniOyun_MouseMove);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.AnaMenuPanel);
            this.Name = "AnaMenu";
            this.Text = "Ana Menü";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaMenu_KeyDown);
            this.AnaMenuPanel.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AnaMenuPanel;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label Cikis;
        private System.Windows.Forms.Label Kontroller;
        private System.Windows.Forms.Label YeniOyun;
    }
}

