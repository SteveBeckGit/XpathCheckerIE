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
            curWIndowLabel.Text = SeleniumFunctions.GetCurTitle();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string xpath = xpathBox.Text;

            if (defaultBtn.Checked)
            {
                List<IWebElement> elements = SeleniumFunctions.FindElements(xpath);

                totalFound.Text = elements.Count.ToString();
            }
            else if (withinFramesBtn.Checked)
            {

            }
            else if (ignoreFrames.Checked)
            {
                SeleniumFunctions.findElementsInFrames(xpath);
                totalFound.Text = SeleniumFunctions.elementsFound.Count.ToString();
            }
           
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            totalFound.Text = "0";
            xpathBox.Text = "";
        }

        private void Checker_Load(object sender, EventArgs e)
        {

        }

        private void DefaultBtn_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void WithinFramesBtn_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void IgnoreFrames_CheckedChanged(object sender, EventArgs e)
        {
         


        }

       

        private void WindowList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SwitchWindow_Click(object sender, EventArgs e)
        {
            string title = WindowList.SelectedItems[0].Text;
            if (!SeleniumFunctions.SwitchWindows(title))
            {
                string message = "Could not find / switch into window";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                }
            }
            else
            {
                curWIndowLabel.Text = SeleniumFunctions.GetCurTitle();
            }
        }

        private void GetWindows_Click(object sender, EventArgs e)
        {
            WindowList.Items.Clear();
            List<string> windows = SeleniumFunctions.GetWindowTitles();
            foreach (string window in windows)
            {
                WindowList.Items.Add(new ListViewItem().Text = window);
            }
        }
    }
}
