using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpathChecker
{
    public partial class Attributes : Form
    {
        public Attributes(WebElement element)
        {
            InitializeComponent();
            foreach (var x in element.Attributes)
            {
                string[] row = new string[] { x.Key, x.Value.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void AttributesView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
