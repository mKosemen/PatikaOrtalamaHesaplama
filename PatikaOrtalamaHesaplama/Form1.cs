using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatikaOrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        ushort[] fibonacci = new ushort[2] { 0, 1 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam=1;
            double ortalama;
            txtOrt.Text = "";
            Array.Resize(ref fibonacci, (ushort)nudDerinlik.Value);
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = (ushort)(fibonacci[i - 1] + fibonacci[i - 2]);
                toplam += fibonacci[i];
            }
            ortalama=(double)toplam / fibonacci.Length;
            txtOrt.Text = ortalama.ToString();
            txtToplam.Text = toplam.ToString();
        }


    }
}
