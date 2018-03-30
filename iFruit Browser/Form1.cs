using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFruit_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wb.Navigate("https://www.lifeinvader.com/");
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtURL.Focused)
            {
                wb.Navigate(txtURL.Text);
            }
           
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (wb.CanGoForward)
            {
                wb.GoForward();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wb.CanGoBack)
            {
                wb.GoBack();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            wb.Navigated += Wb_Navigated;
            wb.Navigating += Wb_Navigating;
        }

        private void Wb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if(!txtURL.Focused)
            {
                txtURL.Text = wb.Url.ToString();
            }
    
        }

        private void Wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            
       }
    }
}
