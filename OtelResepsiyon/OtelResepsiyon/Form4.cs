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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        OtelModelDataContextDataContext db = new OtelModelDataContextDataContext();
        private void Form4_Load(object sender, EventArgs e)
        {
            var sonuc = from t in db.Odas
                        select t;
            dataGridView1.DataSource = sonuc;


        }
    }
}
