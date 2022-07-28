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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Button \n this use for go to \nhelp page for this apllication\nYou Can Single Click And\ngo to Help Page.\nand next Video download \nButton Use for open Youtube video downloader ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Display in \nour Video Player. \nYour Selected Video Playe In this Space");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Display in \nour Video Player. \nYour Selected Video Playe In this Space");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Button set \nFor The our Video Player. \nYou Can Control Your played Video \nfrom this Button Set ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Progress Bar In Our \nVideo Player You Can identify \nwhat is Played video Position and \nhow many time it play");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is  Box is used for \nshow Your Video set and \nselect Video From it.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button use For \ngo to Previous Video");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button use for play the select video");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button use \nfor go to next Video");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button use for \nPause our playerd Video");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This bitton use for \nStop Playerd Video");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button use for \nlord Video On Your Device");
        }
    }
}
