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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string URL = urlBox.Text;
            Checker checker = new Checker(URL);
            checker.Show();
            this.Hide();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (SeleniumFunctions.Driver != null)
            {
                SeleniumFunctions.Driver.Close();
                SeleniumFunctions.Driver.Quit();
            }



        }
    }
}
