using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Galeri galeri = new Galeri();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            galeri.ArabaEkle(cmbMarka.SelectedItem.ToString(),Convert.ToInt16(cmbModel.SelectedItem),cmbRenk.SelectedItem.ToString());
            cmbTextTemizle();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            ArabaListeDoldur();
        }

        void cmbTextTemizle()
        {
            cmbModel.Text = "";
            cmbMarka.Text = "";
            cmbRenk.Text = "";
        }

        private void ArabaListeDoldur()
        {
            listboxArabalar.Items.Clear();
            foreach (Araba a in galeri.ArabaListele() )
            {
                listboxArabalar.Items.Add(a);
            }
        }
       

        private void listboxArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            galeri.ArabaSat((Araba)(sender as ListBox).SelectedItem);
            ArabaListeDoldur();
        }
    }
}
