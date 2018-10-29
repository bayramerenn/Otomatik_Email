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

        Daily daily;
        Monthly monthly;
        Weekly weekly;
        private bool Her;
        private bool BirKereCalis;

        private void Form2_Load(object sender, EventArgs e)
        {
            grpTekBir.Enabled = false;
            teBirkere.Enabled = false;
            deBitisZamani.Enabled = false;
            chcHer.Checked = true;

            if (cboCalisma.SelectedIndex == 0)
            {
                daily = new Daily();

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

                Daily daily = new Daily();

                daily.Dock = DockStyle.Fill;
                panel2.Controls.Add(daily);
            }
            else if (cboCalisma.SelectedIndex == 1)
            {
                foreach (Control item in panel2.Controls)
                {
                    panel2.Controls.Remove(item);
                }

                Weekly weekly = new Weekly();
                weekly.Dock = DockStyle.Fill;
                panel2.Controls.Add(weekly);

            }
            else
            {
                foreach (Control item in panel2.Controls)
                {
                    panel2.Controls.Remove(item);
                }

                Monthly monthly = new Monthly();
                monthly.Dock = DockStyle.Fill;
                panel2.Controls.Add(monthly);


                monthly.seAydaBirikinci.Enabled = false;
                monthly.cmdGun.Enabled = false;
                monthly.cmdZaman.Enabled = false;


            }

        }

        private void chcBirkerecalis_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBirkerecalis.Checked == true)
            {
                BirKereCalis = true;
                speSaatte.Enabled = false;
                cboZamanTipi.Enabled = false;
                teBaslangic.Enabled = false;
                teBitis.Enabled = false;
                teBirkere.Enabled = false;

                teBirkere.Enabled = true;

                chcHer.Checked = false;
                Her = false;
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
                Her = true;
                speSaatte.Enabled = true;
                cboZamanTipi.Enabled = true;
                teBaslangic.Enabled = true;
                teBitis.Enabled = true;
                teBirkere.Enabled = true;
                teBirkere.Enabled = false;

                chcBirkerecalis.Checked = false;
                BirKereCalis = false;
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

            daily = new Daily();

            weekly = new Weekly();


            if (cboCalisma.SelectedIndex == 0 && cboZamanlama.SelectedIndex == 0)
            {
                zaman.ZamanAdi = txtZamanAdi.Text;
                zaman.ZamanTuru = cboZamanlama.Text;
                zaman.Durum = chcDurum.Checked;
                zaman.YinelenenTur = cboCalisma.Text;
                zaman.Gunluk = (int)daily.speGundeBir.Value;
                zaman.CalismaTipi = Her;
                zaman.BirKereCalis = BirKereCalis;
                zaman.CalismaSikligi = (int)speSaatte.Value;
                zaman.CalismaBaslangic = TimeSpan.Parse(BirKereCalis == true ? teBirkere.Text : teBaslangic.Text);
                zaman.CalismaBiris = TimeSpan.Parse(BirKereCalis == true ? "00:00:00" : teBitis.Text);
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
                        zaman.ZamanAdi = txtZamanAdi.Text;
                        zaman.ZamanTuru = cboZamanlama.Text;
                        zaman.Durum = chcDurum.Checked;
                        zaman.YinelenenTur = cboCalisma.Text;
                        zaman.Haftalik = (int)weekly.speHaftadaBir.Value;
                        zaman.HaftaGunleri = gunler.Key;
                        zaman.CalismaTipi = chcHer.Checked;
                        zaman.CalismaSikligi = (int)speSaatte.Value;
                        zaman.CalismaBaslangic = TimeSpan.Parse(teBaslangic.Text);
                        zaman.CalismaBiris = TimeSpan.Parse(teBitis.Text);
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

        }

        public void Temizle()
        {
            daily = new Daily();

            txtZamanAdi.Clear();
            cboZamanlama.SelectedIndex = 0;
            chcDurum.Checked = true;
            cboCalisma.SelectedIndex = 0;
            daily.speGundeBir.Value = 1;
            speSaatte.Value = 1;
            cboCalisma.SelectedIndex = 0;
        }

      
    }
}
