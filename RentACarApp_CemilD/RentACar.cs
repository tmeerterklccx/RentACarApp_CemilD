using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarApp_CemilD
{
    public partial class RentACar : Form
    {
        public RentACar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Araclar araclar = new Araclar();
            //araclar.Show();

        }

        private void uyelerBTN_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();
            uyeler.Show();
        }

        private void markalarBTN_Click(object sender, EventArgs e)
        {
            Markalar markalar = new Markalar();
            markalar.Show();
        }

        private void kiralamalarBTN_Click(object sender, EventArgs e)
        {
            //Kiralamalar kiralamalar = new Kiralamalar();
            //kiralamalar.Show();
        }

        private void bilgilendirmelerBTN_Click(object sender, EventArgs e)
        {
            Bilgilendirme bilgilendirme = new Bilgilendirme();
            bilgilendirme.Show();
        }

        private void RentACar_Load(object sender, EventArgs e)
        {

        }
    }
}
