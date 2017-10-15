using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal sayi1 = 0;
        decimal sayi2 = 0;
        decimal sonuc = 0;
        private void btnHesap_Click(object sender, EventArgs e)
        {
            sayi1 =   Cevir(txtBoxSayi1.Text);
            sayi2 = Cevir(txtBoxSayi2.Text);

          sonuc =   Islemyap();
            txtBoxSonuc.Text = sonuc.ToString();

            
        }

        private decimal Cevir(string text)
        {
            return Convert.ToDecimal(text);
        }

        private decimal Islemyap()
        {
            string islem = cmbBoxIslem.Text;

            if (islem == "+")
            {
               return  sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                return sayi1 - sayi2;
            }
            else if (islem == "*")
            {
              return  sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                return sayi1 / sayi2;
            }
            else
            {
                MessageBox.Show("Yanlış Seçim Yapıldı");
                return 0;

                
            }
           
        
        }

     

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBoxSayi1.Text = " ";
            txtBoxSayi2.Text = "";
            txtBoxSonuc.Text = "";
        }
    }
}
