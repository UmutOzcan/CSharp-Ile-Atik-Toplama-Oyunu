



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Project_19_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int sayi;
        string resim;
        int hacim;
        int sayac = 60;
        int puan = 0;

        int bardakhacim = 250;
        int sisehacim = 600;
        int spritehacim = 350;
        int salcakutusuhacim = 550;
        int dergihacim = 200;
        int gazetehacim = 250;
        int salatalikhacim = 120;
        int domateshacim = 150;
        

        

        public void resimVeHacimSecme() // random sayı üretip resim atamaları ve hacim atamaları
        {
            
            Random rastgele = new Random();
            sayi = rastgele.Next(8);

            if(sayi == 0)
            {
                resim = "bardak";
                pictureBox1.Image = Properties.Resources.cambardak;
                hacim = bardakhacim;
            }

            else if (sayi == 1)
            {
                resim = "dergi";
                pictureBox1.Image = Properties.Resources.dergi;
                hacim = dergihacim;
            }

            else if (sayi == 2)
            {
                resim = "şişe";
                pictureBox1.Image = Properties.Resources.camşişe;
                hacim = sisehacim;
            }

            else if (sayi == 3)
            {
                resim = "domates";
                pictureBox1.Image = Properties.Resources.domates;
                hacim = domateshacim;
            }

            else if (sayi == 4)
            {
                resim = "gazete";
                pictureBox1.Image = Properties.Resources.gazete;
                hacim = gazetehacim;
            }

            else if (sayi == 5)
            {
                resim = "sprite";
                pictureBox1.Image = Properties.Resources.sprite;
                hacim = spritehacim;
            }

            else if (sayi == 6)
            {
                resim = "salcakutusu";
                pictureBox1.Image = Properties.Resources.salçakutusu;
                hacim = salcakutusuhacim;
            }

            else
            {
                resim = "salatalık";
                pictureBox1.Image = Properties.Resources.salatalık;
                hacim = salatalikhacim;
            }

            
                

        }



        
        

        private void btnYeniOyun_Click(object sender, EventArgs e) // yeni  oyun butonuna tıklanınca yapılması gereken işlemler
        {
            puan = 0;
            lblPuan.Text = Convert.ToString(puan);

            timer1.Start();
            sayac = 60;

            
            btnCam.Enabled = true;
            btnCamBosalt.Enabled = true;
            btnKagit.Enabled = true;
            btnKagitBosalt.Enabled = true;
            btnMetal.Enabled = true;
            btnMetalBosalt.Enabled = true;
            btnOrganik.Enabled = true;
            btnOrganikBosalt.Enabled = true;

            btnYeniOyun.ForeColor = Color.Black;

            lblPuan.BackColor = Color.CornflowerBlue;
            lblSure.BackColor = Color.CornflowerBlue;




            resimVeHacimSecme();


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();


            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;


        }

       

        private void timer1_Tick(object sender, EventArgs e) // timer geri sayım işlemleri ve sayım durunca olması gereken işlemler
        {
            lblSure.Text = Convert.ToString(sayac);

            if(sayac>0)
            sayac--;

            if(lblSure.Text == "0")
            {
                btnCam.Enabled = false;
                btnCamBosalt.Enabled = false;
                btnKagit.Enabled = false;
                btnKagitBosalt.Enabled = false;
                btnMetal.Enabled = false;
                btnMetalBosalt.Enabled = false;
                btnOrganik.Enabled = false;
                btnOrganikBosalt.Enabled = false;
            }


        }





        //--------------------ATIK EKLEME İŞLEMLERİ--------------------------------------
        // atıkları ilgili listboxa ekleme, progressbar ayarlamaları ve puan ayarlamaları


        private void btnOrganik_Click(object sender, EventArgs e) 
        {
            if(resim == "domates" )
            {
                if ((progressBar1.Value + domateshacim) <= progressBar1.Maximum)
                {
                    progressBar1.Value += domateshacim;

                    resimVeHacimSecme();

                    listBox1.Items.Add("Domates (150)");

                    puan += domateshacim;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }

            else if (resim == "salatalık")
            {
                if ((progressBar1.Value + salatalikhacim) <= progressBar1.Maximum)
                {
                    progressBar1.Value += salatalikhacim;

                    resimVeHacimSecme();

                    listBox1.Items.Add("Salatalık (120)");

                    puan += salatalikhacim;
                    lblPuan.Text = Convert.ToString(puan);
                }
            }

        }


        private void btnKagit_Click(object sender, EventArgs e) 
        {
            if (resim == "dergi")
            {
                if ((progressBar2.Value + dergihacim) <= progressBar2.Maximum)
                {
                    progressBar2.Value += dergihacim;

                    resimVeHacimSecme();

                    listBox2.Items.Add("Dergi (200)");

                    puan += dergihacim;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }

            else if (resim == "gazete")
            {
                if ((progressBar2.Value + gazetehacim) <= progressBar2.Maximum)
                {
                    progressBar2.Value += gazetehacim;

                    resimVeHacimSecme();

                    listBox2.Items.Add("Gazete (250)");

                    puan += gazetehacim;
                    lblPuan.Text = Convert.ToString(puan);
                }
            }
        }


        private void btnCam_Click(object sender, EventArgs e) 
        {
            if (resim == "şişe")
            {
                if ((progressBar3.Value + sisehacim) <= progressBar3.Maximum)
                {
                    progressBar3.Value += sisehacim;

                    resimVeHacimSecme();

                    listBox3.Items.Add("Şişe (600)");

                    puan += sisehacim;
                    lblPuan.Text = Convert.ToString(puan);
                }
            }

            else if (resim == "bardak")
            {
                if ((progressBar3.Value + bardakhacim) <= progressBar3.Maximum)
                {
                    progressBar3.Value += bardakhacim;

                    resimVeHacimSecme();

                    listBox3.Items.Add("Bardak (250)");

                    puan += bardakhacim;
                    lblPuan.Text = Convert.ToString(puan);
                }
            }

        }


        private void btnMetal_Click(object sender, EventArgs e) 
        {

            if (resim == "salcakutusu")
            {
                if ((progressBar4.Value + salcakutusuhacim) <= progressBar4.Maximum)
                {
                    progressBar4.Value += salcakutusuhacim;

                    resimVeHacimSecme();

                    listBox4.Items.Add("Salça Kutusu (550)");

                    puan += salcakutusuhacim;
                    lblPuan.Text = Convert.ToString(puan);
                }
            }

            else if (resim == "sprite")
            {
                if ((progressBar4.Value + spritehacim) <= progressBar4.Maximum)
                {
                    progressBar4.Value += spritehacim;

                    resimVeHacimSecme();

                    listBox4.Items.Add("Kola Kutusu (350)");

                    puan += spritehacim;
                    lblPuan.Text = Convert.ToString(puan);
                }
            }


        }




        //------------------------------BOŞALTMA İŞLEMLERİ-------------------------------------------
        // boşaltma , süre ve puan işlemleri



        private void btnOrganikBosalt_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > progressBar1.Maximum * 3 / 4)
            {
                progressBar1.Value = 0;
                sayac += 3;
                listBox1.Items.Clear();
            }



        }


        private void btnKagitBosalt_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > progressBar2.Maximum * 3 / 4)
            {
                progressBar2.Value = 0;
                sayac += 3;
                listBox2.Items.Clear();

                puan += 1000;
                lblPuan.Text = Convert.ToString(puan);
            }
        }

        private void btnCamBosalt_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value > progressBar3.Maximum * 3 / 4)
            {
                progressBar3.Value = 0;
                sayac += 3;
                listBox3.Items.Clear();

                puan += 600;
                lblPuan.Text = Convert.ToString(puan);
            }
        }

        private void btnMetalBosalt_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value > progressBar4.Maximum * 3 / 4)
            {
                progressBar4.Value = 0;
                sayac += 3;
                listBox4.Items.Clear();

                puan += 800;
                lblPuan.Text = Convert.ToString(puan);
            }
        }




        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
