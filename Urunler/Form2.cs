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
    public partial class Form2 : Form
    {
        private ListView.SelectedListViewItemCollection Form2Ayrintilar;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ListView.SelectedListViewItemCollection gelenDegerler)
        {
            InitializeComponent();
            this.Form2Ayrintilar = gelenDegerler;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Form2Ayrintilar)
            {
                label1.Text += String.Format("Urun Adi:{0}\nurun Fiyati:{1}", item.SubItems[0].Text, item.SubItems[1].Text);
            }
        }
    }
}
