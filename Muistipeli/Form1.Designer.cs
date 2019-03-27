namespace Muistipeli
{
    partial class MainForm
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
            this.txtBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grBoxPelaajat = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdBtnYksin = new System.Windows.Forms.RadioButton();
            this.lblPelaajaMaara = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtn8 = new System.Windows.Forms.RadioButton();
            this.rdBtn16 = new System.Windows.Forms.RadioButton();
            this.rdBnt30 = new System.Windows.Forms.RadioButton();
            this.lblPeliLauta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnAutot = new System.Windows.Forms.RadioButton();
            this.rdBtnPallot = new System.Windows.Forms.RadioButton();
            this.rdBtnAll = new System.Windows.Forms.RadioButton();
            this.lblAihe = new System.Windows.Forms.Label();
            this.gameControlGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grBoxPelaajat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gameControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxPlayer2
            // 
            this.txtBoxPlayer2.Location = new System.Drawing.Point(134, 43);
            this.txtBoxPlayer2.Name = "txtBoxPlayer2";
            this.txtBoxPlayer2.Size = new System.Drawing.Size(122, 20);
            this.txtBoxPlayer2.TabIndex = 14;
            // 
            // txtBoxPlayer1
            // 
            this.txtBoxPlayer1.Location = new System.Drawing.Point(0, 43);
            this.txtBoxPlayer1.Name = "txtBoxPlayer1";
            this.txtBoxPlayer1.Size = new System.Drawing.Size(122, 20);
            this.txtBoxPlayer1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelaajien nimet ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(864, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 60);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameGroupBox.Location = new System.Drawing.Point(1, 108);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(1084, 814);
            this.gameGroupBox.TabIndex = 2;
            this.gameGroupBox.TabStop = false;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statsGroupBox.BackColor = System.Drawing.SystemColors.Info;
            this.statsGroupBox.Location = new System.Drawing.Point(1, 905);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(1085, 78);
            this.statsGroupBox.TabIndex = 1;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxPlayer2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxPlayer1);
            this.groupBox3.Location = new System.Drawing.Point(596, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 88);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // grBoxPelaajat
            // 
            this.grBoxPelaajat.Controls.Add(this.radioButton1);
            this.grBoxPelaajat.Controls.Add(this.rdBtnYksin);
            this.grBoxPelaajat.Controls.Add(this.lblPelaajaMaara);
            this.grBoxPelaajat.Location = new System.Drawing.Point(34, 4);
            this.grBoxPelaajat.Name = "grBoxPelaajat";
            this.grBoxPelaajat.Size = new System.Drawing.Size(168, 88);
            this.grBoxPelaajat.TabIndex = 1;
            this.grBoxPelaajat.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Kaksin peli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdBtnYksin
            // 
            this.rdBtnYksin.AutoSize = true;
            this.rdBtnYksin.Checked = true;
            this.rdBtnYksin.Location = new System.Drawing.Point(18, 41);
            this.rdBtnYksin.Name = "rdBtnYksin";
            this.rdBtnYksin.Size = new System.Drawing.Size(70, 17);
            this.rdBtnYksin.TabIndex = 2;
            this.rdBtnYksin.TabStop = true;
            this.rdBtnYksin.Text = "Yksin peli";
            this.rdBtnYksin.UseVisualStyleBackColor = true;
            // 
            // lblPelaajaMaara
            // 
            this.lblPelaajaMaara.AutoSize = true;
            this.lblPelaajaMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaajaMaara.Location = new System.Drawing.Point(14, 12);
            this.lblPelaajaMaara.Name = "lblPelaajaMaara";
            this.lblPelaajaMaara.Size = new System.Drawing.Size(137, 20);
            this.lblPelaajaMaara.TabIndex = 1;
            this.lblPelaajaMaara.Text = "Pelaajien määrä";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtn8);
            this.groupBox1.Controls.Add(this.rdBtn16);
            this.groupBox1.Controls.Add(this.rdBnt30);
            this.groupBox1.Controls.Add(this.lblPeliLauta);
            this.groupBox1.Location = new System.Drawing.Point(208, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rdBtn8
            // 
            this.rdBtn8.AutoSize = true;
            this.rdBtn8.Location = new System.Drawing.Point(6, 41);
            this.rdBtn8.Name = "rdBtn8";
            this.rdBtn8.Size = new System.Drawing.Size(97, 17);
            this.rdBtn8.TabIndex = 5;
            this.rdBtn8.Text = "2 X 2 (8 korttia)";
            this.rdBtn8.UseVisualStyleBackColor = true;
            this.rdBtn8.CheckedChanged += new System.EventHandler(this.rdBtn8_CheckedChanged);
            // 
            // rdBtn16
            // 
            this.rdBtn16.AutoSize = true;
            this.rdBtn16.Location = new System.Drawing.Point(116, 41);
            this.rdBtn16.Name = "rdBtn16";
            this.rdBtn16.Size = new System.Drawing.Size(103, 17);
            this.rdBtn16.TabIndex = 6;
            this.rdBtn16.Text = "4 X 4 (16 korttia)";
            this.rdBtn16.UseVisualStyleBackColor = true;
            // 
            // rdBnt30
            // 
            this.rdBnt30.AutoSize = true;
            this.rdBnt30.Checked = true;
            this.rdBnt30.Location = new System.Drawing.Point(6, 58);
            this.rdBnt30.Name = "rdBnt30";
            this.rdBnt30.Size = new System.Drawing.Size(103, 17);
            this.rdBnt30.TabIndex = 7;
            this.rdBnt30.TabStop = true;
            this.rdBnt30.Text = "5 X 6 (30 korttia)";
            this.rdBnt30.UseVisualStyleBackColor = true;
            // 
            // lblPeliLauta
            // 
            this.lblPeliLauta.AutoSize = true;
            this.lblPeliLauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliLauta.Location = new System.Drawing.Point(2, 12);
            this.lblPeliLauta.Name = "lblPeliLauta";
            this.lblPeliLauta.Size = new System.Drawing.Size(140, 20);
            this.lblPeliLauta.TabIndex = 4;
            this.lblPeliLauta.Text = "Peli laudan koko";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnAutot);
            this.groupBox2.Controls.Add(this.rdBtnPallot);
            this.groupBox2.Controls.Add(this.rdBtnAll);
            this.groupBox2.Controls.Add(this.lblAihe);
            this.groupBox2.Location = new System.Drawing.Point(453, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rdBtnAutot
            // 
            this.rdBtnAutot.AutoSize = true;
            this.rdBtnAutot.Location = new System.Drawing.Point(6, 41);
            this.rdBtnAutot.Name = "rdBtnAutot";
            this.rdBtnAutot.Size = new System.Drawing.Size(50, 17);
            this.rdBtnAutot.TabIndex = 9;
            this.rdBtnAutot.Text = "Autot";
            this.rdBtnAutot.UseVisualStyleBackColor = true;
            // 
            // rdBtnPallot
            // 
            this.rdBtnPallot.AutoSize = true;
            this.rdBtnPallot.Location = new System.Drawing.Point(61, 41);
            this.rdBtnPallot.Name = "rdBtnPallot";
            this.rdBtnPallot.Size = new System.Drawing.Size(51, 17);
            this.rdBtnPallot.TabIndex = 10;
            this.rdBtnPallot.Text = "Pallot";
            this.rdBtnPallot.UseVisualStyleBackColor = true;
            // 
            // rdBtnAll
            // 
            this.rdBtnAll.AutoSize = true;
            this.rdBtnAll.Checked = true;
            this.rdBtnAll.Location = new System.Drawing.Point(6, 58);
            this.rdBtnAll.Name = "rdBtnAll";
            this.rdBtnAll.Size = new System.Drawing.Size(54, 17);
            this.rdBtnAll.TabIndex = 11;
            this.rdBtnAll.TabStop = true;
            this.rdBtnAll.Text = "Kaikki";
            this.rdBtnAll.UseVisualStyleBackColor = true;
            // 
            // lblAihe
            // 
            this.lblAihe.AutoSize = true;
            this.lblAihe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAihe.Location = new System.Drawing.Point(2, 12);
            this.lblAihe.Name = "lblAihe";
            this.lblAihe.Size = new System.Drawing.Size(110, 20);
            this.lblAihe.TabIndex = 8;
            this.lblAihe.Text = "Valitse kortit";
            // 
            // gameControlGroupBox
            // 
            this.gameControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameControlGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameControlGroupBox.Controls.Add(this.groupBox1);
            this.gameControlGroupBox.Controls.Add(this.groupBox3);
            this.gameControlGroupBox.Controls.Add(this.grBoxPelaajat);
            this.gameControlGroupBox.Controls.Add(this.btnStart);
            this.gameControlGroupBox.Location = new System.Drawing.Point(1, 23);
            this.gameControlGroupBox.Name = "gameControlGroupBox";
            this.gameControlGroupBox.Size = new System.Drawing.Size(1079, 98);
            this.gameControlGroupBox.TabIndex = 1;
            this.gameControlGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 995);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.gameControlGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 1038);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sss";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grBoxPelaajat.ResumeLayout(false);
            this.grBoxPelaajat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gameControlGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPlayer2;
        private System.Windows.Forms.TextBox txtBoxPlayer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grBoxPelaajat;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdBtnYksin;
        private System.Windows.Forms.Label lblPelaajaMaara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtn8;
        private System.Windows.Forms.RadioButton rdBtn16;
        private System.Windows.Forms.RadioButton rdBnt30;
        private System.Windows.Forms.Label lblPeliLauta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnAutot;
        private System.Windows.Forms.RadioButton rdBtnPallot;
        private System.Windows.Forms.RadioButton rdBtnAll;
        private System.Windows.Forms.Label lblAihe;
        private System.Windows.Forms.GroupBox gameControlGroupBox;
    }
}

