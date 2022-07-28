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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        String[] file, path;

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display.URL = path[SongList.SelectedIndex];
            Display.Ctlcontrols.play();
            possition.Text = "Playing.....";
            timer.Start();
        }

        private void play_Click(object sender, EventArgs e)
        {
            Display.Ctlcontrols.play();
            possition.Text = "Playing.....";
        }

        private void pause_Click(object sender, EventArgs e)
        {
            Display.Ctlcontrols.pause();
            possition.Text = "Pause";
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Display.Ctlcontrols.stop();
            possition.Text = "Stop";
        }

        private void back_Click(object sender, EventArgs e)
        {
            if(SongList.SelectedIndex >0)
            {
                SongList.SelectedIndex = SongList.SelectedIndex-1;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(SongList.SelectedIndex <SongList.Items.Count)
            {
                SongList.SelectedIndex = SongList.SelectedIndex+1;
            }
        }

        private void vol_Scroll(object sender, EventArgs e)
        {
            Display.settings.volume = vol.Value;
            v.Text = vol.Value.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Display.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progress.Maximum = (int)Display.Ctlcontrols.currentItem.duration;
                progress.Value = (int)Display.Ctlcontrols.currentPosition;
            }

            start.Text = Display.Ctlcontrols.currentPositionString;
            end.Text = Display.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Youtube y = new Youtube();
            y.Show();
            this.Hide();
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                file = ofd.SafeFileNames;
                path = ofd.FileNames;
                for (int i = 0; i < file.Length; i++)
                {
                    SongList.Items.Add(file[i]);
                }
            }
        }
    }
}
