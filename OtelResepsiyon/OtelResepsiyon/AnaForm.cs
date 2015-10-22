using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace OtelResepsiyon
{
    public partial class AnaForm : Form
    {


        public AnaForm()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void odalarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void boşOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void oteldekiMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.MdiParent = this;
            frm6.Show();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {



        }
    }
}
