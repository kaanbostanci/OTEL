using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelResepsiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OtelModelDataContextDataContext db = new OtelModelDataContextDataContext();

        private void button1_Click(object sender, EventArgs e)

        {
            
            if (IsValidUser(adTextbox.Text, soyadTextbox.Text))
            {
                AnaForm Anaform = new AnaForm();
                Anaform.Show();
                adTextbox.Clear();
                soyadTextbox.Clear();
            }
            else
            {
                MessageBox.Show("hata var", "hata");
            }
        }

        private bool IsValidUser(string ad, string soyad)
        {
            var sonuc = from i in db.Personels
                        where i.Ad == ad && i.Soyad == soyad && i.Gorev=="resepsiyon"
                        select i;
            return Enumerable.Count(sonuc) > 0;
        }
    }
}
