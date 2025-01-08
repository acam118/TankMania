
namespace TankMania
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.MP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuButton1 = new System.Windows.Forms.Button();
            this.menuButton2 = new System.Windows.Forms.Button();
            this.menuButton3 = new System.Windows.Forms.Button();
            this.menuButton4 = new System.Windows.Forms.Button();
            this.menuButton5 = new System.Windows.Forms.Button();
            this.menuLabel1 = new System.Windows.Forms.Label();
            this.menuPictureBox1 = new System.Windows.Forms.PictureBox();
            this.creditsLabel1 = new System.Windows.Forms.Label();
            this.creditsLabel0 = new System.Windows.Forms.Label();
            this.creditsLabel2 = new System.Windows.Forms.Label();
            this.creditsLabel3 = new System.Windows.Forms.Label();
            this.creditsLabel4 = new System.Windows.Forms.Label();
            this.creditsLabel5 = new System.Windows.Forms.Label();
            this.settingsLabel1 = new System.Windows.Forms.Label();
            this.settingsNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.settingsLabel2 = new System.Windows.Forms.Label();
            this.settingsComboBox1 = new System.Windows.Forms.ComboBox();
            this.settingsLabel3 = new System.Windows.Forms.Label();
            this.settingsComboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.settingsComboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(240, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1440, 810);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(884, 879);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(693, 879);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1073, 879);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(240, 879);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(300, 116);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(1380, 879);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(300, 116);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 484);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Weapon";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1700, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weapon";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 635);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Generate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(77, 665);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(77, 694);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(77, 723);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(77, 752);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(77, 782);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1698, 69);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(206, 484);
            this.listBox2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 930);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 54);
            this.label5.TabIndex = 18;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1501, 38);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(51, 54);
            this.label6.TabIndex = 19;
            this.label6.Text = "0";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(77, 811);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MP1
            // 
            this.MP1.Enabled = true;
            this.MP1.Location = new System.Drawing.Point(77, 840);
            this.MP1.Name = "MP1";
            this.MP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MP1.OcxState")));
            this.MP1.Size = new System.Drawing.Size(75, 23);
            this.MP1.TabIndex = 21;
            this.MP1.Visible = false;
            // 
            // menuButton1
            // 
            this.menuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton1.Location = new System.Drawing.Point(1604, 514);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(300, 75);
            this.menuButton1.TabIndex = 22;
            this.menuButton1.Text = "Play";
            this.menuButton1.UseVisualStyleBackColor = true;
            this.menuButton1.Click += new System.EventHandler(this.menuButton1_Click);
            // 
            // menuButton2
            // 
            this.menuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton2.Location = new System.Drawing.Point(1604, 595);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(300, 75);
            this.menuButton2.TabIndex = 23;
            this.menuButton2.Text = "Settings";
            this.menuButton2.UseVisualStyleBackColor = true;
            this.menuButton2.Click += new System.EventHandler(this.menuButton2_Click);
            // 
            // menuButton3
            // 
            this.menuButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton3.Location = new System.Drawing.Point(1604, 676);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Size = new System.Drawing.Size(300, 75);
            this.menuButton3.TabIndex = 24;
            this.menuButton3.Text = "Credits";
            this.menuButton3.UseVisualStyleBackColor = true;
            this.menuButton3.Click += new System.EventHandler(this.menuButton3_Click);
            // 
            // menuButton4
            // 
            this.menuButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton4.Location = new System.Drawing.Point(1604, 759);
            this.menuButton4.Name = "menuButton4";
            this.menuButton4.Size = new System.Drawing.Size(300, 75);
            this.menuButton4.TabIndex = 25;
            this.menuButton4.Text = "Exit";
            this.menuButton4.UseVisualStyleBackColor = true;
            this.menuButton4.Click += new System.EventHandler(this.menuButton4_Click);
            // 
            // menuButton5
            // 
            this.menuButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton5.Location = new System.Drawing.Point(1890, 0);
            this.menuButton5.Name = "menuButton5";
            this.menuButton5.Size = new System.Drawing.Size(30, 30);
            this.menuButton5.TabIndex = 26;
            this.menuButton5.Text = "X";
            this.menuButton5.UseVisualStyleBackColor = true;
            this.menuButton5.Click += new System.EventHandler(this.menuButton5_Click);
            // 
            // menuLabel1
            // 
            this.menuLabel1.AutoSize = true;
            this.menuLabel1.Font = new System.Drawing.Font("Bauhaus 93", 144F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel1.Location = new System.Drawing.Point(50, 50);
            this.menuLabel1.Name = "menuLabel1";
            this.menuLabel1.Size = new System.Drawing.Size(1161, 218);
            this.menuLabel1.TabIndex = 27;
            this.menuLabel1.Text = "TANK MANIA";
            // 
            // menuPictureBox1
            // 
            this.menuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("menuPictureBox1.Image")));
            this.menuPictureBox1.Location = new System.Drawing.Point(68, 425);
            this.menuPictureBox1.Name = "menuPictureBox1";
            this.menuPictureBox1.Size = new System.Drawing.Size(720, 405);
            this.menuPictureBox1.TabIndex = 28;
            this.menuPictureBox1.TabStop = false;
            // 
            // creditsLabel1
            // 
            this.creditsLabel1.AutoSize = true;
            this.creditsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel1.Location = new System.Drawing.Point(853, 544);
            this.creditsLabel1.Name = "creditsLabel1";
            this.creditsLabel1.Size = new System.Drawing.Size(674, 37);
            this.creditsLabel1.TabIndex = 29;
            this.creditsLabel1.Text = "Game development by Aleksandar Manojlović.";
            // 
            // creditsLabel0
            // 
            this.creditsLabel0.AutoSize = true;
            this.creditsLabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel0.Location = new System.Drawing.Point(853, 793);
            this.creditsLabel0.Name = "creditsLabel0";
            this.creditsLabel0.Size = new System.Drawing.Size(333, 37);
            this.creditsLabel0.TabIndex = 30;
            this.creditsLabel0.Text = "Thank you for playing!";
            // 
            // creditsLabel2
            // 
            this.creditsLabel2.AutoSize = true;
            this.creditsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel2.Location = new System.Drawing.Point(853, 581);
            this.creditsLabel2.Name = "creditsLabel2";
            this.creditsLabel2.Size = new System.Drawing.Size(542, 37);
            this.creditsLabel2.TabIndex = 31;
            this.creditsLabel2.Text = "Art design by Aleksandar Manojlović.";
            // 
            // creditsLabel3
            // 
            this.creditsLabel3.AutoSize = true;
            this.creditsLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel3.Location = new System.Drawing.Point(853, 649);
            this.creditsLabel3.Name = "creditsLabel3";
            this.creditsLabel3.Size = new System.Drawing.Size(621, 37);
            this.creditsLabel3.TabIndex = 32;
            this.creditsLabel3.Text = "Game inspired by the game Pocket Tanks ";
            // 
            // creditsLabel4
            // 
            this.creditsLabel4.AutoSize = true;
            this.creditsLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel4.Location = new System.Drawing.Point(853, 686);
            this.creditsLabel4.Name = "creditsLabel4";
            this.creditsLabel4.Size = new System.Drawing.Size(542, 37);
            this.creditsLabel4.TabIndex = 33;
            this.creditsLabel4.Text = "developed by Michael P. Welch from ";
            // 
            // creditsLabel5
            // 
            this.creditsLabel5.AutoSize = true;
            this.creditsLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel5.Location = new System.Drawing.Point(853, 723);
            this.creditsLabel5.Name = "creditsLabel5";
            this.creditsLabel5.Size = new System.Drawing.Size(312, 37);
            this.creditsLabel5.TabIndex = 34;
            this.creditsLabel5.Text = "Blitwise Productions.";
            // 
            // settingsLabel1
            // 
            this.settingsLabel1.AutoSize = true;
            this.settingsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel1.Location = new System.Drawing.Point(860, 425);
            this.settingsLabel1.Name = "settingsLabel1";
            this.settingsLabel1.Size = new System.Drawing.Size(186, 25);
            this.settingsLabel1.TabIndex = 35;
            this.settingsLabel1.Text = "Number of moves:";
            // 
            // settingsNumericUpDown1
            // 
            this.settingsNumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsNumericUpDown1.Location = new System.Drawing.Point(860, 453);
            this.settingsNumericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.settingsNumericUpDown1.Name = "settingsNumericUpDown1";
            this.settingsNumericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.settingsNumericUpDown1.TabIndex = 36;
            this.settingsNumericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // settingsLabel2
            // 
            this.settingsLabel2.AutoSize = true;
            this.settingsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel2.Location = new System.Drawing.Point(860, 491);
            this.settingsLabel2.Name = "settingsLabel2";
            this.settingsLabel2.Size = new System.Drawing.Size(134, 25);
            this.settingsLabel2.TabIndex = 37;
            this.settingsLabel2.Text = "Game mode:";
            // 
            // settingsComboBox1
            // 
            this.settingsComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsComboBox1.FormattingEnabled = true;
            this.settingsComboBox1.Items.AddRange(new object[] {
            "Unlimited Weapons",
            "Limited Classic",
            "Only Sniper"});
            this.settingsComboBox1.Location = new System.Drawing.Point(860, 520);
            this.settingsComboBox1.Name = "settingsComboBox1";
            this.settingsComboBox1.Size = new System.Drawing.Size(266, 33);
            this.settingsComboBox1.TabIndex = 38;
            this.settingsComboBox1.Text = "Unlimited Weapons";
            // 
            // settingsLabel3
            // 
            this.settingsLabel3.AutoSize = true;
            this.settingsLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel3.Location = new System.Drawing.Point(860, 564);
            this.settingsLabel3.Name = "settingsLabel3";
            this.settingsLabel3.Size = new System.Drawing.Size(90, 25);
            this.settingsLabel3.TabIndex = 39;
            this.settingsLabel3.Text = "Players:";
            // 
            // settingsComboBox2
            // 
            this.settingsComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsComboBox2.FormattingEnabled = true;
            this.settingsComboBox2.Items.AddRange(new object[] {
            "1 player vs Computer",
            "2 players"});
            this.settingsComboBox2.Location = new System.Drawing.Point(860, 592);
            this.settingsComboBox2.Name = "settingsComboBox2";
            this.settingsComboBox2.Size = new System.Drawing.Size(261, 33);
            this.settingsComboBox2.TabIndex = 40;
            this.settingsComboBox2.Text = "1 player vs Computer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 893);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 37);
            this.label7.TabIndex = 41;
            this.label7.Text = "Moves:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(77, 869);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 39);
            this.button11.TabIndex = 42;
            this.button11.Text = "Calculate Shot";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // settingsComboBox3
            // 
            this.settingsComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.settingsComboBox3.FormattingEnabled = true;
            this.settingsComboBox3.Items.AddRange(new object[] {
            "Per turn",
            "Total"});
            this.settingsComboBox3.Location = new System.Drawing.Point(986, 452);
            this.settingsComboBox3.Name = "settingsComboBox3";
            this.settingsComboBox3.Size = new System.Drawing.Size(121, 33);
            this.settingsComboBox3.TabIndex = 43;
            this.settingsComboBox3.Text = "Per turn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(12, 959);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 73);
            this.label8.TabIndex = 44;
            this.label8.Text = "WINNER";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.settingsComboBox3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.settingsComboBox2);
            this.Controls.Add(this.settingsLabel3);
            this.Controls.Add(this.settingsComboBox1);
            this.Controls.Add(this.settingsLabel2);
            this.Controls.Add(this.settingsNumericUpDown1);
            this.Controls.Add(this.settingsLabel1);
            this.Controls.Add(this.creditsLabel5);
            this.Controls.Add(this.creditsLabel4);
            this.Controls.Add(this.creditsLabel3);
            this.Controls.Add(this.creditsLabel2);
            this.Controls.Add(this.creditsLabel0);
            this.Controls.Add(this.creditsLabel1);
            this.Controls.Add(this.menuPictureBox1);
            this.Controls.Add(this.menuLabel1);
            this.Controls.Add(this.menuButton5);
            this.Controls.Add(this.menuButton4);
            this.Controls.Add(this.menuButton3);
            this.Controls.Add(this.menuButton2);
            this.Controls.Add(this.menuButton1);
            this.Controls.Add(this.MP1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Tank Mania";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button10;
        private AxWMPLib.AxWindowsMediaPlayer MP1;
        private System.Windows.Forms.Button menuButton1;
        private System.Windows.Forms.Button menuButton2;
        private System.Windows.Forms.Button menuButton3;
        private System.Windows.Forms.Button menuButton4;
        private System.Windows.Forms.Button menuButton5;
        private System.Windows.Forms.Label menuLabel1;
        private System.Windows.Forms.PictureBox menuPictureBox1;
        private System.Windows.Forms.Label creditsLabel1;
        private System.Windows.Forms.Label creditsLabel0;
        private System.Windows.Forms.Label creditsLabel2;
        private System.Windows.Forms.Label creditsLabel3;
        private System.Windows.Forms.Label creditsLabel4;
        private System.Windows.Forms.Label creditsLabel5;
        private System.Windows.Forms.Label settingsLabel1;
        private System.Windows.Forms.NumericUpDown settingsNumericUpDown1;
        private System.Windows.Forms.Label settingsLabel2;
        private System.Windows.Forms.ComboBox settingsComboBox1;
        private System.Windows.Forms.Label settingsLabel3;
        private System.Windows.Forms.ComboBox settingsComboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox settingsComboBox3;
        private System.Windows.Forms.Label label8;
    }
}

