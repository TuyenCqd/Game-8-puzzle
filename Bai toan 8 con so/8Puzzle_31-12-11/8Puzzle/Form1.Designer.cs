namespace _8Puzzle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSlove = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnLEFT = new System.Windows.Forms.Button();
            this.btnRIGHT = new System.Windows.Forms.Button();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.board1 = new _8Puzzle.Board();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(200, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 163);
            this.panel1.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 244);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New puzzle";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSlove
            // 
            this.btnSlove.Location = new System.Drawing.Point(93, 244);
            this.btnSlove.Name = "btnSlove";
            this.btnSlove.Size = new System.Drawing.Size(93, 23);
            this.btnSlove.TabIndex = 3;
            this.btnSlove.Text = "Slove";
            this.btnSlove.UseVisualStyleBackColor = true;
            this.btnSlove.Click += new System.EventHandler(this.btnSlove_Click);
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(250, 218);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(68, 23);
            this.btnUP.TabIndex = 4;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.UP_Click);
            // 
            // btnLEFT
            // 
            this.btnLEFT.Location = new System.Drawing.Point(210, 244);
            this.btnLEFT.Name = "btnLEFT";
            this.btnLEFT.Size = new System.Drawing.Size(68, 23);
            this.btnLEFT.TabIndex = 5;
            this.btnLEFT.Text = "LEFT";
            this.btnLEFT.UseVisualStyleBackColor = true;
            this.btnLEFT.Click += new System.EventHandler(this.LEFT_Click);
            // 
            // btnRIGHT
            // 
            this.btnRIGHT.Location = new System.Drawing.Point(284, 244);
            this.btnRIGHT.Name = "btnRIGHT";
            this.btnRIGHT.Size = new System.Drawing.Size(68, 23);
            this.btnRIGHT.TabIndex = 6;
            this.btnRIGHT.Text = "RIGHT";
            this.btnRIGHT.UseVisualStyleBackColor = true;
            this.btnRIGHT.Click += new System.EventHandler(this.RIGHT_Click);
            // 
            // btnDOWN
            // 
            this.btnDOWN.Location = new System.Drawing.Point(250, 273);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(68, 23);
            this.btnDOWN.TabIndex = 7;
            this.btnDOWN.Text = "DOWN";
            this.btnDOWN.UseVisualStyleBackColor = true;
            this.btnDOWN.Click += new System.EventHandler(this.DOWN_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 273);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPuzzleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPuzzleToolStripMenuItem
            // 
            this.newPuzzleToolStripMenuItem.Name = "newPuzzleToolStripMenuItem";
            this.newPuzzleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.newPuzzleToolStripMenuItem.Text = "New puzzle";
            this.newPuzzleToolStripMenuItem.Click += new System.EventHandler(this.newPuzzleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(93, 273);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show solution";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(9, 218);
            this.hScrollBar1.Maximum = 50;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(171, 13);
            this.hScrollBar1.TabIndex = 12;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // board1
            // 
            this.board1.AllowDrop = true;
            this.board1.Array = null;
            this.board1.BackColor = System.Drawing.Color.LightGray;
            this.board1.Location = new System.Drawing.Point(12, 40);
            this.board1.Name = "board1";
            this.board1.Size = new System.Drawing.Size(172, 172);
            this.board1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 308);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.board1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnDOWN);
            this.Controls.Add(this.btnRIGHT);
            this.Controls.Add(this.btnLEFT);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnSlove);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "8-Puzzle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSlove;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnLEFT;
        private System.Windows.Forms.Button btnRIGHT;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPuzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShow;
        private Board board1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ListView listView1;
    }
}

