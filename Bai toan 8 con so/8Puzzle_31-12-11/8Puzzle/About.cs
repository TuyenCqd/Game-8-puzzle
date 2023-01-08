using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8Puzzle
{
    public partial class About : Form
    {
        bool change = true;
        public About()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnOK, "Di chuyển chuột vào picture");
        }       

        private void btnOK_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000 && change)
            {
                
                panel2.BackgroundImage = global::_8Puzzle.Properties.Resources._8_puzzle1;
                change = false;
            }
            else
            {
                
                panel2.BackgroundImage = global::_8Puzzle.Properties.Resources._8_puzzle;
                change = true;
            }
        }        

        private void About_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }
    }
}
