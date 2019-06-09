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
        List<WebElement> listed = new List<WebElement>();
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
            
            List<IWebElement> allElements = new List<IWebElement>();
            string xpath = xpathBox.Text;

            if (defaultBtn.Checked)
            {
                allElements = SeleniumFunctions.FindElements(xpath);

                totalFound.Text = allElements.Count.ToString();
            }
            else if (withinFramesBtn.Checked)
            {
                allElements = SeleniumFunctions.findElementsWithinFrames(xpath);
                totalFound.Text = allElements.Count.ToString();
            }
            else if (ignoreFrames.Checked)
            {
                SeleniumFunctions.findElementsInFrames(xpath);
                allElements = SeleniumFunctions.elementsFound;
                totalFound.Text = allElements.Count.ToString();
            }

            foreach (IWebElement element in allElements)
            {
                listed.Add(new WebElement(element));
            }

            foreach (WebElement element in listed)
            {
                Elements.Items.Add(element.Name);
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
            try
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
            catch
            {

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

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            SeleniumFunctions.Shutdown();
            this.Close();
        }

        private void AttributesBtn_Click(object sender, EventArgs e)
        {
            WebElement element = listed.Where(x=>x.Name.Equals(Elements.Text)).First();
            Attributes att = new Attributes(element);
            att.Show();
        }
    }
}
