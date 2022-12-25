namespace NDP_Project_19_20
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.btnMetalBosalt = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnMetal = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.btnCamBosalt = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnCam = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnKagitBosalt = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnKagit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOrganikBosalt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOrganik = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPuan);
            this.panel2.Controls.Add(this.lblSure);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.btnYeniOyun);
            this.panel2.Location = new System.Drawing.Point(12, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 315);
            this.panel2.TabIndex = 1;
            // 
            // lblPuan
            // 
            this.lblPuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(10, 198);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(175, 41);
            this.lblPuan.TabIndex = 5;
            this.lblPuan.Text = "0";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSure
            // 
            this.lblSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(10, 105);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(175, 46);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "60";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "PUAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "SÜRE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.Location = new System.Drawing.Point(10, 254);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(175, 50);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.Color.White;
            this.btnYeniOyun.Location = new System.Drawing.Point(10, 13);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(175, 49);
            this.btnYeniOyun.TabIndex = 0;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(237, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 520);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.progressBar4);
            this.panel7.Controls.Add(this.btnMetalBosalt);
            this.panel7.Controls.Add(this.listBox4);
            this.panel7.Controls.Add(this.btnMetal);
            this.panel7.Location = new System.Drawing.Point(186, 278);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 236);
            this.panel7.TabIndex = 4;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(14, 173);
            this.progressBar4.Maximum = 2300;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(126, 20);
            this.progressBar4.TabIndex = 3;
            // 
            // btnMetalBosalt
            // 
            this.btnMetalBosalt.Enabled = false;
            this.btnMetalBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetalBosalt.Location = new System.Drawing.Point(14, 199);
            this.btnMetalBosalt.Name = "btnMetalBosalt";
            this.btnMetalBosalt.Size = new System.Drawing.Size(126, 26);
            this.btnMetalBosalt.TabIndex = 2;
            this.btnMetalBosalt.Text = "BOŞALT";
            this.btnMetalBosalt.UseVisualStyleBackColor = true;
            this.btnMetalBosalt.Click += new System.EventHandler(this.btnMetalBosalt_Click);
            // 
            // listBox4
            // 
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(14, 36);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(126, 119);
            this.listBox4.TabIndex = 1;
            // 
            // btnMetal
            // 
            this.btnMetal.Enabled = false;
            this.btnMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetal.Location = new System.Drawing.Point(14, 3);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(126, 27);
            this.btnMetal.TabIndex = 0;
            this.btnMetal.Text = "METAL";
            this.btnMetal.UseVisualStyleBackColor = true;
            this.btnMetal.Click += new System.EventHandler(this.btnMetal_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.progressBar3);
            this.panel6.Controls.Add(this.btnCamBosalt);
            this.panel6.Controls.Add(this.listBox3);
            this.panel6.Controls.Add(this.btnCam);
            this.panel6.Location = new System.Drawing.Point(4, 274);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 236);
            this.panel6.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(14, 173);
            this.progressBar3.Maximum = 2200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(126, 20);
            this.progressBar3.TabIndex = 3;
            // 
            // btnCamBosalt
            // 
            this.btnCamBosalt.Enabled = false;
            this.btnCamBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCamBosalt.Location = new System.Drawing.Point(14, 199);
            this.btnCamBosalt.Name = "btnCamBosalt";
            this.btnCamBosalt.Size = new System.Drawing.Size(126, 26);
            this.btnCamBosalt.TabIndex = 2;
            this.btnCamBosalt.Text = "BOŞALT";
            this.btnCamBosalt.UseVisualStyleBackColor = true;
            this.btnCamBosalt.Click += new System.EventHandler(this.btnCamBosalt_Click);
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(14, 36);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(126, 119);
            this.listBox3.TabIndex = 1;
            // 
            // btnCam
            // 
            this.btnCam.Enabled = false;
            this.btnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCam.Location = new System.Drawing.Point(14, 3);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(126, 27);
            this.btnCam.TabIndex = 0;
            this.btnCam.Text = "CAM";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.progressBar2);
            this.panel5.Controls.Add(this.btnKagitBosalt);
            this.panel5.Controls.Add(this.listBox2);
            this.panel5.Controls.Add(this.btnKagit);
            this.panel5.Location = new System.Drawing.Point(186, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 237);
            this.panel5.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(14, 173);
            this.progressBar2.Maximum = 1200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(126, 20);
            this.progressBar2.TabIndex = 3;
            // 
            // btnKagitBosalt
            // 
            this.btnKagitBosalt.Enabled = false;
            this.btnKagitBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKagitBosalt.Location = new System.Drawing.Point(14, 199);
            this.btnKagitBosalt.Name = "btnKagitBosalt";
            this.btnKagitBosalt.Size = new System.Drawing.Size(126, 26);
            this.btnKagitBosalt.TabIndex = 2;
            this.btnKagitBosalt.Text = "BOŞALT";
            this.btnKagitBosalt.UseVisualStyleBackColor = true;
            this.btnKagitBosalt.Click += new System.EventHandler(this.btnKagitBosalt_Click);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(14, 36);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(126, 119);
            this.listBox2.TabIndex = 1;
            // 
            // btnKagit
            // 
            this.btnKagit.Enabled = false;
            this.btnKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKagit.Location = new System.Drawing.Point(14, 3);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(126, 27);
            this.btnKagit.TabIndex = 0;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = true;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.btnOrganikBosalt);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.btnOrganik);
            this.panel4.Location = new System.Drawing.Point(4, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 237);
            this.panel4.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 173);
            this.progressBar1.Maximum = 700;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(126, 20);
            this.progressBar1.TabIndex = 3;
            // 
            // btnOrganikBosalt
            // 
            this.btnOrganikBosalt.Enabled = false;
            this.btnOrganikBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganikBosalt.Location = new System.Drawing.Point(14, 199);
            this.btnOrganikBosalt.Name = "btnOrganikBosalt";
            this.btnOrganikBosalt.Size = new System.Drawing.Size(126, 26);
            this.btnOrganikBosalt.TabIndex = 2;
            this.btnOrganikBosalt.Text = "BOŞALT";
            this.btnOrganikBosalt.UseVisualStyleBackColor = true;
            this.btnOrganikBosalt.Click += new System.EventHandler(this.btnOrganikBosalt_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 119);
            this.listBox1.TabIndex = 1;
            // 
            // btnOrganik
            // 
            this.btnOrganik.Enabled = false;
            this.btnOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganik.Location = new System.Drawing.Point(14, 3);
            this.btnOrganik.Name = "btnOrganik";
            this.btnOrganik.Size = new System.Drawing.Size(126, 27);
            this.btnOrganik.TabIndex = 0;
            this.btnOrganik.Text = "ORGANİK ATIK";
            this.btnOrganik.UseVisualStyleBackColor = true;
            this.btnOrganik.Click += new System.EventHandler(this.btnOrganik_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "ATIK KUTULARI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 198);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOrganikBosalt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOrganik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button btnMetalBosalt;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button btnCamBosalt;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnKagitBosalt;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnKagit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

