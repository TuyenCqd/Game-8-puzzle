using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Puzzle
{
    enum EventTickOnFORM
    {
        NONE = 0, RESIZE = 1, STARTRUN = 2
    }

    enum MoveDirection
    {
        UP = 1, LEFT = 2, DOWN = 3, RIGHT = 4
    }

    class Node
    {
        public const int Size = 3;
        public const int BlankValue = 0;
        MoveDirection Direction;
        Goal goal;
        int id;
        int h, f, g;
        int[,] arrNode;
        Node dad;
        int BlankI, BlankJ;

                        
        public Node()
        {
            goal = new Goal();
            arrNode = goal.GOAL_EVEN;
            BlankI = 0;
            BlankJ = 0;
        }

        public int BlankI_pos
        {
            get { return BlankI; }
            set { BlankI = value; }
        }

        public int BlankJ_pos
        {
            get { return BlankJ; }
            set { BlankJ = value; }
        }

        public MoveDirection DIRECTION
        {
            get { return Direction; }
            set { Direction = value; }
        }

        public int Label
        {
            get { return id; }
        }

        public int F
        {
            get
            {
                return f;
            }
            set { f = value; }
        }

        public int G
        {
            get { return g; }
            set { g = value; }
        }

        public int Heuristic
        {
            get { return h; }
            set 
            {                 
                h = value;
                f = g + h;
            }
        }

        public int[,] ArrayNode
        {
            get { return arrNode; }
            set
            {
                arrNode = value;
                GetID();
            }
        }

        internal Node Parent
        {
            get { return dad; }
            set { dad = value; }
        }

        public int this[int i,int j]
        {
            get { return arrNode[i, j]; }
            set { arrNode[i, j] = value; }
        }


        /// <summary>
        /// Update id
        /// </summary>
        public void GetID()
        {
            id = 0;
            int n = 1;

            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                {
                    if (arrNode[i, j] == BlankValue)
                    {
                        BlankI = i;
                        BlankJ = j;
                    }
                    id += arrNode[i, j] * n;
                    n *= 10;
                }
        }

        public Node Clone()
        {
            Node m = (Node)this.MemberwiseClone();
            m.ArrayNode = (int[,])this.ArrayNode.Clone();
            return m;
        }

        /// <summary>
        /// Random matrix
        /// </summary>
        public void Random()
        {
            Random rnd = new Random();
            int[] t = null;

            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                {
                    int num = rnd.Next(arrNode.Length);
                    t = Goal.FindPosValue(num, arrNode);
                    if (arrNode[i, j] != num)
                    {
                        int temp = arrNode[i, j];
                        arrNode[i, j] = num;

                        arrNode[t[0], t[1]] = temp;
                        if (arrNode[i, j] == BlankValue)
                        {
                            BlankI = i;
                            BlankJ = j;
                        }
                        if (arrNode[t[0], t[1]] == BlankValue)
                        {
                            BlankI = t[0];
                            BlankJ = t[1];
                        }
                    }
                }
            GetID();
        }

        

        public void Move(MoveDirection direc)
        {
            int temI = BlankI, tempJ = BlankJ;
            if (direc == MoveDirection.UP)
            {
                BlankI--;
            }
            else if (direc == MoveDirection.DOWN)
            {
                BlankI++;
            }
            else if (direc == MoveDirection.LEFT)
            {
                BlankJ--;
            }
            else// if (direc == MoveDirection.RIGHT)
            {
                BlankJ++;
            }
            arrNode[temI, tempJ] = arrNode[BlankI, BlankJ];
            arrNode[BlankI, BlankJ] = BlankValue;
            GetID();
        }

        public bool CanMoveUp
        {
            get { return BlankI > 0; }
        }
        public bool CanMoveDown
        {
            get { return BlankI < 2; }
        }
        public bool CanMoveLeft
        {
            get { return BlankJ > 0; }
        }
        public bool CanMoveRight
        {
            get { return BlankJ < 2; }
        }
 
    }
}
