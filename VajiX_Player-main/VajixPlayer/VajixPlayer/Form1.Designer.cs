namespace VajixPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SongList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.vol = new System.Windows.Forms.TrackBar();
            this.volumn = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.possition = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Display = new AxWMPLib.AxWindowsMediaPlayer();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.SongList);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.v);
            this.groupBox2.Controls.Add(this.vol);
            this.groupBox2.Controls.Add(this.volumn);
            this.groupBox2.Controls.Add(this.load);
            this.groupBox2.Controls.Add(this.stop);
            this.groupBox2.Controls.Add(this.pause);
            this.groupBox2.Controls.Add(this.next);
            this.groupBox2.Controls.Add(this.play);
            this.groupBox2.Controls.Add(this.back);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(-2, 637);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1275, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // SongList
            // 
            this.SongList.BackColor = System.Drawing.Color.Black;
            this.SongList.ForeColor = System.Drawing.Color.Lime;
            this.SongList.FormattingEnabled = true;
            this.SongList.ItemHeight = 28;
            this.SongList.Location = new System.Drawing.Point(899, 30);
            this.SongList.Name = "SongList";
            this.SongList.Size = new System.Drawing.Size(367, 32);
            this.SongList.TabIndex = 13;
            this.SongList.SelectedIndexChanged += new System.EventHandler(this.SongList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "%";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(776, 31);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(22, 28);
            this.v.TabIndex = 11;
            this.v.Text = "0";
            // 
            // vol
            // 
            this.vol.Location = new System.Drawing.Point(626, 29);
            this.vol.Maximum = 100;
            this.vol.Name = "vol";
            this.vol.Size = new System.Drawing.Size(133, 45);
            this.vol.TabIndex = 100;
            this.vol.Scroll += new System.EventHandler(this.vol_Scroll);
            // 
            // volumn
            // 
            this.volumn.BackColor = System.Drawing.Color.Black;
            this.volumn.Image = ((System.Drawing.Image)(resources.GetObject("volumn.Image")));
            this.volumn.Location = new System.Drawing.Point(563, 24);
            this.volumn.Name = "volumn";
            this.volumn.Size = new System.Drawing.Size(57, 44);
            this.volumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volumn.TabIndex = 9;
            this.volumn.TabStop = false;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Black;
            this.load.Image = ((System.Drawing.Image)(resources.GetObject("load.Image")));
            this.load.Location = new System.Drawing.Point(436, 24);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(57, 44);
            this.load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.load.TabIndex = 8;
            this.load.TabStop = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Black;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(373, 24);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(57, 44);
            this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stop.TabIndex = 7;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Black;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(287, 24);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(57, 44);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause.TabIndex = 6;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Black;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Location = new System.Drawing.Point(224, 24);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(57, 44);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.next.TabIndex = 5;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Black;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(161, 24);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(57, 44);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play.TabIndex = 4;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(98, 24);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 44);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 3;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(-2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // possition
            // 
            this.possition.AutoSize = true;
            this.possition.BackColor = System.Drawing.Color.Black;
            this.possition.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possition.ForeColor = System.Drawing.Color.Lime;
            this.possition.Location = new System.Drawing.Point(510, 2);
            this.possition.Name = "possition";
            this.possition.Size = new System.Drawing.Size(52, 19);
            this.possition.TabIndex = 5;
            this.possition.Text = "VajiX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(1159, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "VajiX_Player";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(38, 627);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1206, 13);
            this.progress.TabIndex = 7;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Lime;
            this.start.Location = new System.Drawing.Point(12, 605);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(54, 19);
            this.start.TabIndex = 8;
            this.start.Text = "00.00";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.Color.Black;
            this.end.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.ForeColor = System.Drawing.Color.Lime;
            this.end.Location = new System.Drawing.Point(1219, 605);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(54, 19);
            this.end.TabIndex = 9;
            this.end.Text = "00.00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Display
            // 
            this.Display.Enabled = true;
            this.Display.Location = new System.Drawing.Point(-2, 2);
            this.Display.Name = "Display";
            this.Display.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Display.OcxState")));
            this.Display.Size = new System.Drawing.Size(1275, 694);
            this.Display.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(119, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Online";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 723);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.possition);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VajixPLayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox SongList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.TrackBar vol;
        private System.Windows.Forms.PictureBox volumn;
        private System.Windows.Forms.PictureBox load;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label possition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Timer timer;
        private AxWMPLib.AxWindowsMediaPlayer Display;
        private System.Windows.Forms.Button button2;
    }
}

