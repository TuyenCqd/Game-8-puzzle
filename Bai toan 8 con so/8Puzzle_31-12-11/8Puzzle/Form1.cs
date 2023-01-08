using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _8Puzzle
{
    public partial class Form1 : Form
    {
        ColumnHeader columnHeader1;
        EventTickOnFORM frm = EventTickOnFORM.NONE;

        Game game;
        int i = 1;
        bool addLView;
        int curX, curY, X;
        int[,] mArray;
        int index = 0, timeTick = 0;

        public Form1()
        {
            InitializeComponent();
            mArray = new int[Node.Size, Node.Size];
            game = new Game();
            LoadButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            curX = ClientSize.Width;
            curY = ClientSize.Height;
            X = curX;
            btnSlove.Enabled = false;
            LRDU(false);
            btnShow.Enabled = false;
        }

        void LoadButton()
        {
            int i = 0;
            int distance = 6;
            int sizeX = 50;
            int sizeY = 48;
            int X = 4, Y = 4;//size static
            Button[,] mang_So = new Button[Node.Size, Node.Size];
            for (int row = 0; row < Node.Size; row++)
            {
                for (int col = 0; col < Node.Size; col++)
                {
                    mang_So[row, col] = new Button();
                    mang_So[row, col].Location = new Point(X, Y);
                    mang_So[row, col].Size = new Size(sizeX, sizeY);
                    mang_So[row, col].TextAlign = ContentAlignment.MiddleCenter;
                    mang_So[row, col].UseVisualStyleBackColor = true;
                    if (i != 0)
                        mang_So[row, col].Text = i.ToString();
                    i++;
                    panel1.Controls.Add(mang_So[row, col]);
                    mang_So[row, col].Click += new System.EventHandler(this.button_Click);
                    X += distance + sizeX;
                }
                X = 4;
                Y += distance + sizeY;
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            index++;
            int t = 0;
            Button btn = (Button)sender;
            if (btn.Text != "")
            {
                t = int.Parse(btn.Text);
            }

            switch (index)
            {
                case 1:
                    mArray[0, 0] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(0, 0);
                    break;
                case 2:
                    mArray[0, 1] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(0, 1);
                    break;
                case 3:
                    mArray[0, 2] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(0, 2);
                    break;
                case 4:
                    mArray[1, 0] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(1, 0);
                    break;
                case 5:
                    mArray[1, 1] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(1, 1);
                    break;
                case 6:
                    mArray[1, 2] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(1, 2);
                    break;
                case 7:
                    mArray[2, 0] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(2, 0);
                    break;
                case 8:
                    mArray[2, 1] = t;
                    if (t == Node.BlankValue)
                        Set_blankPos(2, 1);
                    break;
                case 9:
                    {
                        index = 0;
                        mArray[2, 2] = t;
                        if (t == Node.BlankValue)
                            Set_blankPos(2, 2);
                        game.NODE.ArrayNode = mArray;
                        LRDU(true);
                        btnSlove.Enabled = true;
                        btnRandom.Enabled = false;
                        btnRandom.Enabled = false;
                    }
                    break;
            }
            board1.Array = mArray;
            btn.Enabled = false;
        }

        void Set_blankPos(int i, int j)
        {
            game.NODE.BlankI_pos = i;
            game.NODE.BlankJ_pos = j;
        }

        private void UP_Click(object sender, EventArgs e)
        {
            if (game.NODE.CanMoveUp)
            {
                game.NODE.Move(MoveDirection.UP);
                board1.Array = game.NODE.ArrayNode;
            }
            btnSlove.Enabled = true;
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            if (game.NODE.CanMoveLeft)
            {
                game.NODE.Move(MoveDirection.LEFT);
                board1.Array = game.NODE.ArrayNode;
            }
            btnSlove.Enabled = true;
        }

        private void RIGHT_Click(object sender, EventArgs e)
        {
            if (game.NODE.CanMoveRight)
            {
                game.NODE.Move(MoveDirection.RIGHT);
                //board1.Invalidate();//redrawn
                board1.Array = game.NODE.ArrayNode;
            }
            btnSlove.Enabled = true;
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            if (game.NODE.CanMoveDown)
            {
                game.NODE.Move(MoveDirection.DOWN);
                //board1.Invalidate();
                board1.Array = game.NODE.ArrayNode;
            }
            btnSlove.Enabled = true;
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            mArray = new int[Node.Size, Node.Size];
            index = 0;
            EnableInput(true);
            btnShow.Enabled = false;
            btnSlove.Enabled = false;
            LRDU(false);
            game.NODE.ArrayNode = mArray;
            board1.Array = null;
            btnRandom.Enabled = false;

            ClearListView();

            frm = EventTickOnFORM.NONE;
            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnSlove.Enabled = false;
            btnShow.Enabled = false;
            LRDU(false);
            newPuzzleToolStripMenuItem.Enabled = true;
            if (!addLView)
            {
                AddListView();
            }

            timer1.Enabled = true;//start tick time
            frm = EventTickOnFORM.RESIZE;//Resize Form
            timer1.Interval = 10;
        }

        /// <summary>
        /// Button slove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSlove_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
            //st.Start();
            game.Slove();
            //st.Stop();
            if (game.SOLUTION.Count == 0)
            {
                MessageBox.Show("Please, you should create new game");
                btnNew.Enabled = true;
                btnRandom.Enabled = true;
            }
            else
            {
                MessageBox.Show("Solution found in " + game.SOLUTION.Count + " steps. Click Show Solution button to see the animation", "Solution Finder");
                btnShow.Enabled = true;
                btnRandom.Enabled = false;
                btnNew.Enabled = false;
                btnSlove.Enabled = false;
                newPuzzleToolStripMenuItem.Enabled = false;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ClearListView();
            game.Shuffle();
            mArray = game.NODE.ArrayNode;
            board1.Array = mArray;

            EnableInput(false);
            btnSlove.Enabled = true;
        }
        /// <summary>
        /// Enabled Button derection
        /// </summary>
        /// <param name="value"></param>
        void LRDU(bool value)
        {
            btnRIGHT.Enabled = value;
            btnUP.Enabled = value;
            btnLEFT.Enabled = value;
            btnDOWN.Enabled = value;
        }
        /// <summary>
        /// Enabled button input
        /// </summary>
        /// <param name="value"></param>
        private void EnableInput(bool value)
        {
            foreach (Control ctl in panel1.Controls)
                ctl.Enabled = value;
            btnShow.Enabled = value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (frm)
            {
                case EventTickOnFORM.STARTRUN://Run board
                    {
                        if (game.SOLUTION.Count > 0)
                        {
                            MoveDirection Move = game.SOLUTION.Pop();//save nuoc di chuyen                
                            game.NODE.Move(Move);
                            Move_Printed(Move);//Show Moving
                            board1.Array = game.NODE.ArrayNode;//paint board
                        }
                        else//Sorting is finshed
                        {
                            timer1.Enabled = false;
                            EnableInput(true);
                            btnRandom.Enabled = true;
                            btnShow.Enabled = false;
                            btnNew.Enabled = true;
                            LRDU(true);
                        }
                    }
                    break;
                //Resize form size
                case EventTickOnFORM.RESIZE:
                    {
                        X += 2;
                        if (X < curX + listView1.Size.Width)
                        {
                            Thread.Sleep(10);
                            this.ClientSize = new Size(X, curY);//Resize
                        }
                        else
                        {
                            frm = EventTickOnFORM.STARTRUN;
                            this.listView1.Visible = true;
                            timer1.Interval = 100 + (timeTick << 2);
                        }
                    }
                    break;
                //Resize form size
                case EventTickOnFORM.NONE:
                    {
                        if (X > curX)
                        {
                            X -= 4;
                            Thread.Sleep(10);
                            this.ClientSize = new Size(X, curY);//Resize
                        }
                        else
                        {
                            timer1.Enabled = false;
                            timer1.Interval = 100 + (timeTick << 2);
                        }
                    }
                    break;
            }
        }

        private void newPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timeTick = hScrollBar1.Value;
            if (timeTick != 0)
            {
                timer1.Interval = 100 + (timeTick << 2);
            }
        }

        /// <summary>
        /// Show the move direction of blank
        /// </summary>
        void Move_Printed(MoveDirection move)
        {
            switch (move)
            {
                case MoveDirection.LEFT: listView1.Items.Add("Move#" + (i++).ToString() + ":" + " LEFT"); break;
                case MoveDirection.RIGHT: listView1.Items.Add("Move#" + (i++).ToString() + ":" + " RIGHT"); break;
                case MoveDirection.UP: listView1.Items.Add("Move#" + (i++).ToString() + ":" + " UP"); break;
                case MoveDirection.DOWN: listView1.Items.Add("Move#" + (i++).ToString() + ":" + " DOWN"); break;
            }
        }
        /// <summary>
        /// Create the List View
        /// </summary>
        void AddListView()
        {
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Move History";
            columnHeader1.Width = 114;

            this.listView1.Activation = ItemActivation.OneClick;
            this.listView1.Alignment = ListViewAlignment.Left;
            this.listView1.BorderStyle = BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            //this.listView1.Dock = DockStyle.Right;
            this.listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.listView1.HoverSelection = true;
            this.listView1.ImeMode = ImeMode.Off;
            this.listView1.Location = new Point(381, 24);
            this.listView1.Size = new Size(120, 284);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.listView1.Visible = false;
            this.Controls.Add(this.listView1);
            addLView = true;

        }
        /// <summary>
        /// Clear List View
        /// </summary>
        void ClearListView()
        {
            if (listView1 != null)
            {
                i = 1;
                listView1.Items.Clear();
                if (listView1.Items.Count != 0)
                {
                    listView1.Visible = false;
                }
            }
        }
    }
}
