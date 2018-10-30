using CivilEmail.Model;
using CivilEmail.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CivilEmail
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Daily daily = new Daily();
        Monthly monthly = new Monthly();
        Weekly weekly = new Weekly();
       

    
      

        private void Form2_Load(object sender, EventArgs e)
        {
            grpTekBir.Enabled = false;
            teBirkere.Enabled = false;
            deBitisZamani.Enabled = false;
            chcHer.Checked = true;
            monthly.seAydaBirikinci.Enabled = false;
            monthly.cboGun.Enabled = false;
            monthly.cboZaman.Enabled = false;


            if (cboCalisma.SelectedIndex == 0)
            {
                

                daily.Dock = DockStyle.Fill;
                panel2.Controls.Add(daily);
            }



        }

        private void cmbZamanlama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboZamanlama.SelectedIndex == 0)
            {
                grpTekBir.Enabled = false;
                grpYinelenen.Enabled = true;
            }
            else
            {
                grpTekBir.Enabled = true;
                grpYinelenen.Enabled = false;
            }
        }

        private void cmbCalisma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCalisma.SelectedIndex == 0)
            {
                foreach (Control item in panel2.Controls)
                {
                    panel2.Controls.Remove(item);
                }

                

                daily.Dock = DockStyle.Fill;
                panel2.Controls.Add(daily);
            }
            else if (cboCalisma.SelectedIndex == 1)
            {
                foreach (Control item in panel2.Controls)
                {
                    panel2.Controls.Remove(item);
                }

               
                weekly.Dock = DockStyle.Fill;
                panel2.Controls.Add(weekly);

            }
            else
            {
                foreach (Control item in panel2.Controls)
                {
                    panel2.Controls.Remove(item);
                }

               
                monthly.Dock = DockStyle.Fill;
                panel2.Controls.Add(monthly);
            }

        }

        private void chcBirkerecalis_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBirkerecalis.Checked == true)
            {
               
                speSaatte.Enabled = false;
                cboZamanTipi.Enabled = false;
                teBaslangic.Enabled = false;
                teBitis.Enabled = false;
                teBirkere.Enabled = false;

                teBirkere.Enabled = true;

                chcHer.Checked = false;
               
            }
            else
            {
                chcBirkerecalis.Checked = false;
            }
        }

        private void chcHer_CheckedChanged(object sender, EventArgs e)
        {
            if (chcHer.Checked == true)
            {
            
                speSaatte.Enabled = true;
                cboZamanTipi.Enabled = true;
                teBaslangic.Enabled = true;
                teBitis.Enabled = true;
                teBirkere.Enabled = true;
                teBirkere.Enabled = false;

                chcBirkerecalis.Checked = false;
           
            }
            else
            {
                chcHer.Checked = false;
            }
        }



        private void chcZamanYok_CheckedChanged(object sender, EventArgs e)
        {
            if (chcZamanYok.Checked == true)
            {
                deBitisZamani.Enabled = false;
                chcBitisZamani.Checked = false;
            }
            else
            {
                chcZamanYok.Checked = false;
            }
        }

        private void chcBitisZamani_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBitisZamani.Checked == true)
            {
                deBitisZamani.Enabled = true;
                chcZamanYok.Checked = false;
            }
            else
            {
                chcBitisZamani.Checked = false;
            }
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BTHEntities1 db = new BTHEntities1();
            Zamanlayici zaman = new Zamanlayici();

           
      

            
            if (cboCalisma.SelectedIndex == 0 && cboZamanlama.SelectedIndex == 0)
            {
                zaman.Haftalik = 0;
                zaman.Aylik = 0;
                zaman.Gunler = "";
                zaman.AyGunu = 0;
                zaman.AyTuru = "";
                zaman.ZamanAdi = txtZamanAdi.Text;
                zaman.ZamanTuru = cboZamanlama.Text;
                zaman.Durum = chcDurum.Checked;
                zaman.YinelenenTur = cboCalisma.Text;
                zaman.Gunluk = (int)daily.speGundeBir.Value;
                zaman.CalismaTipi = chcBirkerecalis.Checked==true ? true:false;
            
                zaman.ZamanTipi = chcHer.Checked == true ? cboZamanTipi.Text : "";
                zaman.CalismaSuresi = chcHer.Checked == true ? (int)speSaatte.Value : 0;
                zaman.CalismaBaslangic = TimeSpan.Parse(chcBirkerecalis.Checked == true ? teBirkere.Text : teBaslangic.Text);
                zaman.CalismaBiris = TimeSpan.Parse(chcBirkerecalis.Checked == true ? "00:00:00" : teBitis.Text);
                zaman.ZamanBaslangic = Convert.ToDateTime(deBaslangicZamani.Text);
                zaman.ZamanBitis = Convert.ToDateTime
                    (chcZamanYok.Checked == true ? "01.01.2090" : deBitisZamani.Text);
                try
                {
                    db.Zamanlayici.Add(zaman);
                    db.SaveChanges();
                    Temizle();
                    MessageBox.Show("kayıt eklendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Hata");
                }
            }
            else if (cboCalisma.SelectedIndex == 1 && cboZamanlama.SelectedIndex == 0)
            {

                foreach (var gunler in Gunler.gunler)
                {
                    if (gunler.Value)
                    {
                        zaman.Gunluk = 0;
                        zaman.Aylik = 0;
                        zaman.AyGunu = 0;
                        zaman.AyTuru = "";
                        zaman.ZamanAdi = txtZamanAdi.Text;
                        zaman.ZamanTuru = cboZamanlama.Text;
                        zaman.Durum = chcDurum.Checked;
                        zaman.YinelenenTur = cboCalisma.Text;
                        zaman.Haftalik = (int)weekly.speHaftadaBir.Value;
                        zaman.Gunler = gunler.Key;
                        zaman.CalismaTipi = chcBirkerecalis.Checked == true ? true : false; ;
               
                        zaman.ZamanTipi = chcHer.Checked == true ? cboZamanTipi.Text : "";
                        zaman.CalismaSuresi = chcHer.Checked == true ? (int)speSaatte.Value : 0;
                        zaman.CalismaBaslangic = TimeSpan.Parse(chcBirkerecalis.Checked == true ? teBirkere.Text : teBaslangic.Text);
                        zaman.CalismaBiris = TimeSpan.Parse(chcBirkerecalis.Checked == true ? "00:00:00" : teBitis.Text);
                        zaman.ZamanBaslangic = Convert.ToDateTime(deBaslangicZamani.Text);
                        zaman.ZamanBitis = Convert.ToDateTime
                            (chcZamanYok.Checked == true ? "01.01.2090" : deBitisZamani.Text);
                        try
                        {
                            db.Zamanlayici.Add(zaman);
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString(), "Hata");
                        }

                    }
                }
                MessageBox.Show("Kayıt Eklendi");
                Temizle();



            }

            else if (cboCalisma.SelectedIndex == 2 && cboZamanlama.SelectedIndex == 0)
            {
                if (monthly.chcHerilk.Checked)
                {
                    zaman.Gunluk = 0;
                    zaman.Haftalik = 0;
                    zaman.ZamanAdi = txtZamanAdi.Text;
                    zaman.ZamanTuru = cboZamanlama.Text;
                    zaman.Durum = chcDurum.Checked;
                    zaman.YinelenenTur = cboCalisma.Text;
                    zaman.Aylik = (int)monthly.seAydaBir.Value;
                    zaman.AyGunu = (int)monthly.seGunu.Value;
                    zaman.AyTuru = "";
                    zaman.Gunler = "";
                    zaman.CalismaTipi = chcBirkerecalis.Checked == true ? true : false;
                    zaman.ZamanTipi = chcHer.Checked==true?cboZamanTipi.Text : "";
                    zaman.CalismaSuresi = chcHer.Checked == true ? (int)speSaatte.Value:0;
                    zaman.CalismaBaslangic = TimeSpan.Parse(chcBirkerecalis.Checked == true ? teBirkere.Text : teBaslangic.Text);
                    zaman.CalismaBiris = TimeSpan.Parse(chcBirkerecalis.Checked == true ? "00:00:00" : teBitis.Text);
                    zaman.ZamanBaslangic = Convert.ToDateTime(deBaslangicZamani.Text);
                    zaman.ZamanBitis = Convert.ToDateTime
                        (chcZamanYok.Checked == true ? "01.01.2090" : deBitisZamani.Text);

                    try
                    {
                        db.Zamanlayici.Add(zaman);
                        db.SaveChanges();
                        Temizle();
                        MessageBox.Show("Kayıt Edildi");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString(), "Hata");
                    }
                }
                else
                {
                    zaman.Gunluk = 0;
                    zaman.Haftalik = 0;
                    zaman.AyGunu = 0;
                    zaman.ZamanAdi = txtZamanAdi.Text;
                    zaman.ZamanTuru = cboZamanlama.Text;
                    zaman.Durum = chcDurum.Checked;
                    zaman.YinelenenTur = cboCalisma.Text;
                    zaman.Aylik = (int)monthly.seAydaBirikinci.Value;
                    zaman.AyTuru = monthly.cboZaman.Text;
                    zaman.CalismaTipi = chcBirkerecalis.Checked == true ? true : false;
                    zaman.Gunler = monthly.cboGun.Text;
                    zaman.ZamanTipi = chcHer.Checked == true ? cboZamanTipi.Text : "";
                    zaman.CalismaSuresi = chcHer.Checked == true ? (int)speSaatte.Value : 0;
                    zaman.CalismaBaslangic = TimeSpan.Parse(chcBirkerecalis.Checked == true ? teBirkere.Text : teBaslangic.Text);
                    zaman.CalismaBiris = TimeSpan.Parse(chcBirkerecalis.Checked == true ? "00:00:00" : teBitis.Text);
                    zaman.ZamanBaslangic = Convert.ToDateTime(deBaslangicZamani.Text);
                    zaman.ZamanBitis = Convert.ToDateTime
                        (chcZamanYok.Checked == true ? "01.01.2090" : deBitisZamani.Text);

                    try
                    {
                        db.Zamanlayici.Add(zaman);
                        db.SaveChanges();
                        Temizle();
                        MessageBox.Show("Kayıt Edildi");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString(), "Hata");
                    }
                }
               
            }
        }

        public void Temizle()
        {
           

            txtZamanAdi.Clear();
            cboZamanlama.SelectedIndex = 0;
            chcDurum.Checked = true;
            cboCalisma.SelectedIndex = 0;
            daily.speGundeBir.Value = 1;
            speSaatte.Value = 1;
            cboCalisma.SelectedIndex = 0;
            monthly.seAydaBir.Value = 1;
            monthly.seGunu.Value = 1;

        }

      
    }
}
