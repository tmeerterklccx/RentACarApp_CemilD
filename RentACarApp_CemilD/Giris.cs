using RentACarApp_CemilD;

namespace RentACarApp_CemilD
{
    public partial class Giris : Form
    {
        public Giris()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentACar rentacar = new RentACar();
            if (tcTBox.Text != "")
            {


                rentacar.kullanici.Text = tcTBox.Text;
                rentacar.yetki.Text = "Admin";
            }
            rentacar.ShowDialog();
        }
    }
}

