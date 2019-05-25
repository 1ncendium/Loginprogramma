using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Website_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Agenda ss = new Agenda();
            ss.Show();
        }

        private void Web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.outpostict.com/");
        }

        private void Tools_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/1ncendium/Loginprogramma");
        }
    }
}
