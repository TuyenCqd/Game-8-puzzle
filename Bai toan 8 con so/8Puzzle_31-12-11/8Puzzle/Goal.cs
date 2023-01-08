using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Puzzle
{
    //trạng thái đích của bài toán
    class Goal
    {
        int[,] even;        
        int[,] odd;

        public int[,] GOAL_ODD
        {
            get { return odd; }
        }

        public int[,] GOAL_EVEN
        {
            get { return even; }
        }

        public Goal()
        {
            even = new int[Node.Size, Node.Size];
            odd = new int[Node.Size, Node.Size];
            //N chẳng            
            even[0, 0] = 0;
            even[0, 1] = 1;
            even[0, 2] = 2;
            even[1, 0] = 3;
            even[1, 1] = 4;
            even[1, 2] = 5;
            even[2, 0] = 6;
            even[2, 1] = 7;
            even[2, 2] = 8;
            //N lẻ            
            odd[0, 0] = 1;
            odd[0, 1] = 2;
            odd[0, 2] = 3;
            odd[1, 0] = 8;
            odd[1, 1] = 0;
            odd[1, 2] = 4;
            odd[2, 0] = 7;
            odd[2, 1] = 6;
            odd[2, 2] = 5;
        }

        public static int[] FindPosValue(int value, int[,] mang)
        {
            int[] t = new int[2];
            bool finish = false;
            for (int i = 0; !finish && i < Node.Size; i++)
                for (int j = 0; !finish && j < Node.Size; j++)
                {
                    if (mang[i, j] == value)
                    {
                        t[0] = i;
                        t[1] = j;
                        finish = true;
                    }
                }
            return t;
        }

        public int[] Goal_Even(int value)
        {
            int[] t = new int[2];
            bool finish = false;
            for (int i = 0; !finish && i < Node.Size; i++)
                for (int j = 0; !finish && j < Node.Size; j++)
                {
                    if (even[i, j] == value)
                    {
                        t[0] = i;
                        t[1] = j;
                        finish = true;
                    }
                }
            return t;
        }

        public int[] Goal_Odd(int value)
        {
            int[] t = new int[2];
            bool finish = false;
            for (int i = 0; !finish && i < Node.Size; i++)
                for (int j = 0; !finish && j < Node.Size; j++)
                {
                    if (odd[i, j] == value)
                    {
                        t[0] = i;
                        t[1] = j;
                        finish = true;
                    }
                }
            return t;
        }

    }
}
