using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VajixPlayer
{
    public partial class Youtube : Form
    {
        public Youtube()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<iframe id ='video' src='https://www.youtube.com/embed/{0}' width='1240' height='645' frameborder='0' allowfullscreen></iframe>";
                html += "</head></html>";
                this.web.DocumentText = String.Format(html, link.Text.Split('=')[1]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
