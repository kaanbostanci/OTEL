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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OtelModelDataContextDataContext db = new OtelModelDataContextDataContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var sonuc = from t in db.Musteris
                        select t;

            dataGridView1.DataSource = sonuc;
        }
    }
}
