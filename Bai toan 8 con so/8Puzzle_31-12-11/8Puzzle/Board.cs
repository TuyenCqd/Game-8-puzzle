using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace _8Puzzle
{
    public partial class Board : UserControl
    {        
        private const int x0 = 200;
        private const int y0 = 200;
        const int _size = 3;
        private Font myFont;
        private int[,] _array;
        private float cellWidth;
        
        public Board()
        {
            InitializeComponent();
            myFont = new Font("Tahoma", 16);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {            
            if (_array != null)
            {
                DrawMatrix(e.Graphics, _array);
            }
            if (_size > 0)
            {
                cellWidth = (float)(this.Width - 0.8) / _size;
                DrawGrid(e.Graphics);
            }
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            this.Width = Math.Min(this.Width, this.Height);
            this.Height = this.Width;

            base.OnResize(e);
        }

        public int[,] Array
        {
            get { return _array; }
            set
            {
                _array = value;
                this.Invalidate();
            }
        }

        public void DrawMatrix(Graphics g, int[,] array)
        {
            for (int i = 0; i < Node.Size; i++)
            {
                for (int j = 0; j < Node.Size; j++)
                {
                    
                    if (array[i,j] == Node.BlankValue)
                    {
                        g.FillRectangle(Brushes.Gray, cellWidth * j, cellWidth * i, cellWidth, cellWidth);
                    }
                    else
                    {
                        string s = array[i,j].ToString();
                        if (s == "0") s = string.Empty;
                        SizeF size = g.MeasureString(s, myFont);
                        float left = cellWidth * j + (cellWidth - size.Width) / 2;
                        float top = cellWidth * i + (cellWidth - size.Height) / 2;
                        g.DrawString(s, myFont, Brushes.Blue, left, top);
                    }
                }
            }

        }

        private void DrawGrid(Graphics g)
        {
            for (int i = 0; i <= _size; i++)
            {
                g.DrawLine(Pens.Black, 0, i * cellWidth, this.Width, i * cellWidth);
                g.DrawLine(Pens.Black, i * cellWidth, 0, i * cellWidth, this.Width);
            }
        }
    }
}
