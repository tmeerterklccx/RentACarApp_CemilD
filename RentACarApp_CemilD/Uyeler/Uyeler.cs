using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace RentACarApp_CemilD
{
    public partial class Uyeler : Form
    {
        private readonly IUserService _userService;
        public Uyeler()
        {
            InitializeComponent();
        }

        public Uyeler(IUserService userService, IContainer components, DataGridView dataGridView1, Button button1, Button button2, Button uyeSil_BTN, TextBox textBox1, TextBox textBox2, Label label1, Label label2, Button button3)
        {
            _userService = userService;
            this.components = components;
            this.dataGridView1 = dataGridView1;
            this.button1 = button1;
            this.button2 = button2;
            this.uyeSil_BTN = uyeSil_BTN;
            this.textBox1 = textBox1;
            this.textBox2 = textBox2;
            this.label1 = label1;
            this.label2 = label2;
            this.button3 = button3;
        }

        public void uyeEkle_BTN(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
        }
        public void uyeGuncelle_BTN(object sender, EventArgs e)
        {
            UyeGuncelle uyeGuncelle = new UyeGuncelle();
            uyeGuncelle.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeGuncelle uyeGuncelle = new UyeGuncelle();
            uyeGuncelle.Show();
        }

        private void uyeEkle_BTN_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
        }

        private void Uyeler_Load(object sender, EventArgs e)
        {
            UyeleriGetir();

        }

        private void UyeleriGetir()
        {
            DataTable dataTable = new DataTable();
            var users = _userService.TGetAll();
            foreach (var user in users)
            {
                dataTable.Rows.Add(user.UserID, user.TC, user.Ad, user.Soyad, user.Telefon, user.EMail, user.Adres, user.Yetki, user.Statu);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void uyeSil_BTN_Click(object sender, EventArgs e)
        {
            textBoxDoldur();
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].ToString());
            var user = _userService.TGetById(id);
            if (user != null)
            {
                _userService.TDelete(user);
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBoxDoldur()
        {
            textBox1.Text = dataGridView1.SelectedRows[1].ToString();
            textBox2.Text = dataGridView1.SelectedRows[2].ToString();
        }
    }
}
