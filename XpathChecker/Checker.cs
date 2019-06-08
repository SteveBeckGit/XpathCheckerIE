using OpenQA.Selenium;
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
    public partial class Checker : Form
    {
        public Checker(string url)
        {
            InitializeComponent();
            SeleniumFunctions.Launch(url);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string xpath = xpathBox.Text;
            List<IWebElement> elements = SeleniumFunctions.FindElements(xpath);

            totalFound.Text = elements.Count.ToString();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            totalFound.Text = "0";
            xpathBox.Text = "";
        }

        private void Checker_Load(object sender, EventArgs e)
        {

        }
    }
}
