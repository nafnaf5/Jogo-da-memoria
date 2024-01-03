using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Media;

namespace Jogo_da_memoria
{
    public  class Form1 : System.Windows.Forms.Form
    {
        private SoundPlayer player;

        public int[,] arr = new int[4, 5];
        public int[] a = new int[17];
        private PictureBox img1;
        private PictureBox img2;
        private int i = 0;
        private int j = 0;
        private int C1 = 0;
        private int C2 = 0;
        private int gc = 0;
        private int Jogador = 1;
        bool temp = false;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private System.ComponentModel.IContainer components;


        public Form1()
    {
        InitializeComponent();
    }
        protected override void Dispose(bool ExibeTabuleiroposing)
        {
            if (ExibeTabuleiroposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(ExibeTabuleiroposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Media.SoundPlayer();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.LoadTimeout = 10000;
            this.player.SoundLocation = "image/flipcard.wav";
            this.player.Stream = null;
            this.player.Tag = null;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(29, 31);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(69, 94);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(121, 31);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(69, 94);
            this.pictureBox22.TabIndex = 1;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(212, 31);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(69, 94);
            this.pictureBox23.TabIndex = 2;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Click += new System.EventHandler(this.pictureBox23_Click);
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(300, 31);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(69, 94);
            this.pictureBox24.TabIndex = 3;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Click += new System.EventHandler(this.pictureBox24_Click);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(389, 31);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(69, 94);
            this.pictureBox25.TabIndex = 4;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Click += new System.EventHandler(this.pictureBox25_Click);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(29, 145);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(69, 94);
            this.pictureBox26.TabIndex = 9;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Click += new System.EventHandler(this.pictureBox26_Click);
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(121, 145);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(69, 94);
            this.pictureBox27.TabIndex = 8;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Click += new System.EventHandler(this.pictureBox27_Click);
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(212, 145);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(69, 94);
            this.pictureBox28.TabIndex = 7;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Click += new System.EventHandler(this.pictureBox28_Click);
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(300, 145);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(69, 94);
            this.pictureBox29.TabIndex = 6;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Click += new System.EventHandler(this.pictureBox29_Click);
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(389, 145);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(69, 94);
            this.pictureBox30.TabIndex = 5;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Click += new System.EventHandler(this.pictureBox30_Click);
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(29, 263);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(69, 94);
            this.pictureBox31.TabIndex = 14;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Click += new System.EventHandler(this.pictureBox31_Click);
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(121, 263);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(69, 94);
            this.pictureBox32.TabIndex = 13;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Click += new System.EventHandler(this.pictureBox32_Click);
            // 
            // pictureBox33
            // 
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(212, 263);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(69, 94);
            this.pictureBox33.TabIndex = 12;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Click += new System.EventHandler(this.pictureBox33_Click);
            // 
            // pictureBox34
            // 
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(300, 263);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(69, 94);
            this.pictureBox34.TabIndex = 11;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.Click += new System.EventHandler(this.pictureBox34_Click);
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(389, 263);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(69, 94);
            this.pictureBox35.TabIndex = 10;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.Click += new System.EventHandler(this.pictureBox35_Click);
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(29, 376);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(69, 94);
            this.pictureBox36.TabIndex = 19;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.Click += new System.EventHandler(this.pictureBox36_Click);
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(121, 376);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(69, 94);
            this.pictureBox37.TabIndex = 18;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Click += new System.EventHandler(this.pictureBox37_Click);
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(212, 376);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(69, 94);
            this.pictureBox38.TabIndex = 17;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Click += new System.EventHandler(this.pictureBox38_Click);
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(300, 376);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(69, 94);
            this.pictureBox39.TabIndex = 16;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Click += new System.EventHandler(this.pictureBox39_Click);
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(389, 376);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(69, 94);
            this.pictureBox40.TabIndex = 15;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.Click += new System.EventHandler(this.pictureBox40_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "Novo Jogo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Jogador1: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Jogador 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(488, 572);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Jogo da Memória";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
        public void Form1_ran()
        {
            Random r1 = new Random();
            int count = 0;
            bool flag = true;
            int b = 0;
            while (count < 10)
            {
                flag = true;
                while (flag == true)
                {
                    b = r1.Next(1, 17);
                    if (a[b] == 0)
                    {
                        a[b] = 1;
                        ++count;
                        flag = false;
                    }
                }
                flag = true;
                while (flag == true)
                {
                    int i = r1.Next(0, 4);
                    int j = r1.Next(0, 5);
                    if (arr[i, j] == 0)
                    {
                        arr[i, j] = b;
                        flag = false;
                    }
                }
                flag = true;
                while (flag == true)
                {
                    int i = r1.Next(0, 4);
                    int j = r1.Next(0, 5);
                    if (arr[i, j] == 0)
                    {
                        arr[i, j] = b;
                        flag = false;
                    }
                }

            }
        }

        public void ExibeTabuleiro(int i, int j, object sender)
        {
            PictureBox x = (PictureBox)sender;
            string str = "image/" + arr[i, j] + ".jpg";
            x.Image = new Bitmap(str);
            gc++;
            if (gc % 2 == 0)
            {
                img2 = (PictureBox)sender;
                temp = true;
                gc = 0;
                C2 = arr[i, j];
                if (C1 == C2 && img1 != img2)
                {
                    if (Jogador == 1)
                    {
                        int score = Int32.Parse(label5.Text);
                        score += 10;
                        label5.Text = "" + score;
                        gc = 0;
                    }
                    else
                    {
                        int score = Int32.Parse(label6.Text);
                        score += 10;
                        label6.Text = "" + score;
                        gc = 0;
                    }
                    img1.Visible = false;
                    img2.Visible = false;
                }
                else
                {
                    if (img1 == img2)
                    {
                        gc--;
                    }
                    else
                    {
                        timer1.Enabled = true;
                        if (Jogador == 1)
                            Jogador = 2;
                        else
                            Jogador = 1;
                        defineJogador();
                    }
                }
            }
            else
            {
                this.i = i;
                this.j = j;
                C1 = arr[i, j];
                img1 = (PictureBox)sender;
            }
        }
        private void defineJogador()
        {
            if (Jogador == 1)
            {
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.ForeColor = Color.Green;
                label3.ForeColor = Color.Red;
            }
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Form1_ran();
        }

       
        private void button1_Click(object sender, System.EventArgs e)
        {
            label5.Text = "0";
            label6.Text = "0";
            //PictureBox n=(PictureBox)sender;
            string stn = "image/bg.jpg";
            pictureBox21.Image = new Bitmap(stn);
            pictureBox21.Visible = true;
            pictureBox22.Image = new Bitmap(stn);
            pictureBox22.Visible = true;
            pictureBox23.Image = new Bitmap(stn);
            pictureBox23.Visible = true;
            pictureBox24.Image = new Bitmap(stn);
            pictureBox24.Visible = true;
            pictureBox25.Image = new Bitmap(stn);
            pictureBox25.Visible = true;
            pictureBox26.Image = new Bitmap(stn);
            pictureBox26.Visible = true;
            pictureBox27.Image = new Bitmap(stn);
            pictureBox27.Visible = true;
            pictureBox28.Image = new Bitmap(stn);
            pictureBox28.Visible = true;
            pictureBox29.Image = new Bitmap(stn);
            pictureBox29.Visible = true;
            pictureBox30.Image = new Bitmap(stn);
            pictureBox30.Visible = true;
            pictureBox31.Image = new Bitmap(stn);
            pictureBox31.Visible = true;
            pictureBox32.Image = new Bitmap(stn);
            pictureBox32.Visible = true;
            pictureBox33.Image = new Bitmap(stn);
            pictureBox33.Visible = true;
            pictureBox34.Image = new Bitmap(stn);
            pictureBox34.Visible = true;
            pictureBox35.Image = new Bitmap(stn);
            pictureBox35.Visible = true;
            pictureBox36.Image = new Bitmap(stn);
            pictureBox36.Visible = true;
            pictureBox37.Image = new Bitmap(stn);
            pictureBox37.Visible = true;
            pictureBox38.Image = new Bitmap(stn);
            pictureBox38.Visible = true;
            pictureBox39.Image = new Bitmap(stn);
            pictureBox39.Visible = true;
            pictureBox40.Image = new Bitmap(stn);
            pictureBox40.Visible = true;
        }

        // falta fazer o botao para sair
        /*private void button1_click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void label5_Click_1(object sender, EventArgs e)
        {
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(0,0, pictureBox21);
            player.Play();
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(0, 1, pictureBox22);
            player.Play();
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(0, 2, pictureBox23);
            player.Play();
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(0, 3, pictureBox24);
            player.Play();
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(0, 4, pictureBox25);
            player.Play();
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(1, 0, pictureBox26);
            player.Play();
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(1, 1, pictureBox27);
            player.Play();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(1, 2, pictureBox28);
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(1, 3, pictureBox29);
            player.Play();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(1, 4, pictureBox30);
            player.Play();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(2,0, pictureBox31);
            player.Play();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(2, 1, pictureBox32);
            player.Play();
        }
        private void pictureBox33_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(2, 2, pictureBox33);
            player.Play();
        }
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(2, 3, pictureBox34);
            player.Play();
        }
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(2, 4, pictureBox35);
            player.Play();
        }
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(3, 0, pictureBox36);
            player.Play();
        }
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(3, 1, pictureBox37);
            player.Play();
        }
        private void pictureBox38_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(3, 2, pictureBox38);
            player.Play();
        }
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(3, 3, pictureBox39);
            player.Play();
        }
        private void pictureBox40_Click(object sender, EventArgs e)
        {
            ExibeTabuleiro(3, 4, pictureBox40);
            player.Play();
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (C2 != C1)
            {
                img1.Image = new Bitmap("image/bg.jpg");
                img2.Image = new Bitmap("image/bg.jpg");
                timer1.Enabled = false;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
 }
