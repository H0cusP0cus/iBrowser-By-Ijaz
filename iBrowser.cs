using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simple_webbrowser
{

    public partial class Form1 : Form
    {
        string profile = "https://github.com/h0cusp0cus";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = e.Url.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            textBox1.Focus();
            webBrowser1.Navigate(profile);
            

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.MaximumProgress;
            progressBar1.Value = (int)e.CurrentProgress;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(button1.Size.Width + 5, button1.Size.Height + 15);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(button1.Size.Width - 5, button1.Size.Height - 15);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Size = new Size(button2.Size.Width + 5, button2.Size.Height + 15);

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(button2.Size.Width - 5, button2.Size.Height - 15);

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new Size(button3.Size.Width + 5, button3.Size.Height + 15);

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(button3.Size.Width - 5, button3.Size.Height - 15);

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Size = new Size(button4.Size.Width + 5, button4.Size.Height + 15);

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(button4.Size.Width - 5, button4.Size.Height - 15);

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Size = new Size(button5.Size.Width + 5, button5.Size.Height + 15);

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Size = new Size(button5.Size.Width - 5, button5.Size.Height - 15);

        }
    }
}
