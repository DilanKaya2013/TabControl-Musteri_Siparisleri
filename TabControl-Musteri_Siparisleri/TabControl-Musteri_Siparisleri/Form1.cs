using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl_Musteri_Siparisleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal corbaFiyat = 50;
            decimal salataFyat = 40;
            decimal anaYemekFiyat = 120;
            decimal tatliFiyat = 75;

            decimal toplamTutar = 0;
            if (tabControl1.SelectedIndex == 2)
            {
                string ad=txtAdSoyad.Text;
                string telefon=txtTelefon.Text;
                decimal corbaToplam = 0;
                decimal salataToplam = 0;
               decimal anayemekToplam=0;
                decimal tatliToplam=0;


                lblHesap.Text="Müşteri Adı: "+ad+"n";
                lblHesap.Text = "Müşteri Telefon numarası:" + telefon+"\n";
                
               
                if (numCorba.Value > 0)
                {
                    corbaToplam+=numCorba.Value*corbaFiyat;
                    toplamTutar+=corbaToplam;
                }

                if (numSalata.Value > 0)
                {
                    salataToplam += numSalata.Value * salataFyat;
                    toplamTutar += salataToplam;
                }

                if (numAnaYemek.Value > 0)
                {
                   salataToplam += numAnaYemek.Value * anaYemekFiyat;
                    toplamTutar += salataToplam;
                }

                if (numTatli.Value > 0)
                {
                    tatliToplam+= numTatli.Value * tatliFiyat;
                    toplamTutar += tatliToplam;
                }


                lblHesap.Text = String.Format("Ad: {0}\nTelefon: {1}\n\n" +
                     "================================\n" +
                      "{2} x Çorba = {3}\n" +
                      "{4} x Salata = {5}\n" +
                      "{6} x Ana Yemek = {7}\n" +
                     "{8} x Tatlı = {9}\n" +
                      "=================================\n" +
                      "Toplam Fiyat: {10}\n" +
                      "=================================\n" +
                      "Afiyet olsun. Teşekkür Ederiz.",
                     ad,
                     telefon,
                numCorba.Value,
                     corbaToplam,
                  numSalata.Value,
                      salataToplam,
                   numAnaYemek.Value,
                    anayemekToplam,
                numTatli.Value,
                     tatliToplam,toplamTutar
                     );





                lblHesap.Text += string.Format("Toplam Ödenecek : " + toplamTutar);


                

            }



           
        }
    }
}
