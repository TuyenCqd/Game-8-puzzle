using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Puzzle
{
    class Game
    {
        Stack<MoveDirection> Solution;        
        AlgorithmSearch HSearch;
        static bool slove;
        Node node;
        public Game()
        {
            Solution = new Stack<MoveDirection>();
            HSearch = new AlgorithmSearch();
            node = new Node();
        }

        public Stack<MoveDirection> SOLUTION
        {
            get { return Solution; }
            set { Solution = value; }
        }

        public static bool SLOVE
        {
            get { return slove; }
            set { slove = value; }
        }

        internal Node NODE//internal
        {
            get { return node; }
            set { node = value; }
        }
        
        /// <summary>
        /// Gam can slove
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool CanSlove()
        {
            int N = 0;
            int[] temp = new int[node.ArrayNode.Length];

            for (int i = 0; i < node.ArrayNode.GetLength(0); i++ )
                for (int j = 0; j < node.ArrayNode.GetLength(0); j++)
                {
                    temp[i * node.ArrayNode.GetLength(0) + j] = node.ArrayNode[i, j];
                }

            for (int i = 0; i < temp.Length; i++)
            {
                int t = temp[i];
                if (t > 1)
                {
                    //xét ô kế tiếp
                    for (int m = i + 1; m < temp.Length; m++)
                        if (temp[m] != 0 && temp[m] < t)
                            N++;
                }
            }
            if (N % 2 == 0)
            {
                slove = true;//số chẳng
            }
            else
            {
                slove = false;
            }
            return slove;                
        }

        /// <summary>
        /// Giải bài toán
        /// </summary>
        public void Slove()
        {
            CanSlove();
            HSearch.AStar(node);
            Solution = HSearch.SULUTION;

        }

        public void Shuffle()
        {
            node.Random();
        }
    }
}
