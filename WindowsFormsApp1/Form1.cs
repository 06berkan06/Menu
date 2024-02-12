using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "form sınıfı uygulama2";
            this.BackColor = Color.Cornsilk;
            this.ForeColor = Color.Black;
            this.Size = new Size(300, 150);
            lblAdSoyad.Text = "Adınız";
            lblAdSoyad.Location = new Point(10, 10);
            lblAdSoyad.Size = new Size(65, 15);
            lblAdSoyad.ForeColor = Color.OrangeRed;
            txtAdSoyad.Location = new Point(75, 10);
            btnGiris.Location = new Point(100, 50);
            btnGiris.Text = "Giriş";
            btnGiris.BackColor = Color.White;
            txtAdSoyad.Size = new Size(150, 15);
            txtAdSoyad.TabIndex = 2;
            txtAdSoyad.KeyPress += TxtAdSoyad_KeyPress;
            btnGiris.Click += BtnGiris_Click;
            this.Controls.Add(lblAdSoyad);
            this.Controls.Add(txtAdSoyad);
            this.Controls.Add(btnGiris);

        }
         Label lblAdSoyad=new Label();
         TextBox txtAdSoyad=new TextBox();
         Button btnGiris = new Button();
           
            
        private void TxtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        public void BtnGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba " + txtAdSoyad.Text);
        }
    }
}
