using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urunler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.Add("Soguk icecekler");
            cmbKategori.Items.Add("Sicak icecekler");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();
            li.Text = txtAd.Text;
            li.SubItems.Add(txtFiyat.Text);
            li.SubItems.Add(txtStok.Text);
            li.SubItems.Add(cmbKategori.Text);
            listView1.Items.Add(li);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListView.SelectedListViewItemCollection Secilenler = listView1.SelectedItems;
            Form2 frm = new Form2(Secilenler);
            frm.ShowDialog();
        }
    }
}
