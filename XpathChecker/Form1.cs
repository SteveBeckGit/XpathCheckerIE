using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpathChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            foreach (string url in UrlLibrary.ReadUrls())
            {
                urlSelect.Items.Add(url);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string URL = urlSelect.Text;

            Regex htmlRegex = new Regex(@"http?s?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)");
            Match html = htmlRegex.Match(URL);

            if (html.Success)
            {
                UrlLibrary.WriteToLibrary(URL);
                Checker checker = new Checker(URL);
                checker.Show();
                this.Hide();
            }
            else
            {
                string message = "Malformed URL, please ensure http: or https: is used";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                }
            }

         
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (SeleniumFunctions.Driver != null)
            {
                SeleniumFunctions.Driver.Close();
                SeleniumFunctions.Driver.Quit();
            }



        }

        private void UrlSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UrlLibrary.ClearLibrary();
            urlSelect.Items.Clear();
        }
    }
}
