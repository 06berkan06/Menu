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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Müşteri_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                listbox.Items.Clear();
             
                listbox.Items.Add("");
                listbox.Items.Add(txtAdSoyad.Text + "\r\n");
                listbox.Items.Add( txtTelefon.Text + "\r\n");
                listbox.Items.Add(txtAdres.Text + "\r\n");
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 12;
                    listbox.Items.Add(  (nCorba.Value+" çorba ",(nCorba.Value * 12).ToString()+" tl") + "\r\n");
                }
                listbox.Items.Add("-----------------");
                
                if (nSalata.Value > 0)
                {
                    hesap += nSalata.Value * 5;
                    listbox.Items.Add((nSalata.Value + " salata ", (nSalata.Value * 5).ToString() + " tl") + "\r\n");
                }
                listbox.Items.Add("-----------------");
              
                if (nYemek.Value > 0)
                {
                    hesap += nYemek.Value * 15;
                    listbox.Items.Add((nYemek.Value + " yemek", (nYemek.Value * 15).ToString() + " tl") + "\r\n");
                }
                listbox.Items.Add("-----------------");
                if (nTatli.Value > 0)
                {
                    hesap += nTatli.Value * 10;
                    listbox.Items.Add((nTatli.Value + " tatlı ", (nTatli.Value * 10).ToString() + " tl") + "\r\n");
                }
                listbox.Items.Add(("Toplam ", hesap.ToString()));
            }
        }
    }
}
