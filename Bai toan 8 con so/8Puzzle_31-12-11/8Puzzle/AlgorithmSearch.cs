using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Puzzle
{
    class AlgorithmSearch
    {
        const int GOAL = 0;       
        Stack<MoveDirection> Solution;
        Goal g;
        PQ Open, closeQ;        

        public AlgorithmSearch()
        {
            Solution = new Stack<MoveDirection>();
            Open = new PQ();
            closeQ = new PQ();
            g = new Goal();            
        }

        public Stack<MoveDirection> SULUTION
        {
            get { return Solution; }
            set { Solution = value; }
        }
        
        /// <summary>
        /// Best First Search
        /// </summary>
        public void AStar(Node node)
        {            
            // Làm rỗng các collection
            Open.Clear();
            closeQ.Clear();
            Solution.Clear();
            node.Parent = null;
            node.Heuristic = Evaluate(node);
            Open.Add(node);

            while (Open.Count > 0)
            {
                Node m = Open[0];
                // Kiểm tra xem có phải trạng thái đích
                if (m.Heuristic == GOAL)
                {
                    // Tạo solution
                    TrackPath(m);
                    break;
                }
                // Xóa node đầu tiên của OPEN
                Open.Remove(m);
                // Sinh các node tiếp theo của node m
                if(m.G < 30)
                    GenMove(m);
            }
        }

        /// <summary>
        /// Lấy đường đi từ matrix hiện tại đến matrix bắt đầu
        /// </summary>
        /// <param name="matrix"></param>
        private void TrackPath(Node node)
        {
            if (node.Parent != null)
            {
                Solution.Push(node.DIRECTION);
                TrackPath(node.Parent);
            }
        }

        /// <summary>
        /// Sinh nước đi
        /// </summary>
        /// <param name="node"></param>
        private void GenMove(Node node)
        {
            closeQ.Add(node);            
            // Sinh ra các node con
            if (node.DIRECTION != MoveDirection.LEFT && node.CanMoveRight)
            {
                CloneMove(node, MoveDirection.RIGHT);
            }

            if (node.DIRECTION != MoveDirection.RIGHT && node.CanMoveLeft)
            {
                CloneMove(node, MoveDirection.LEFT);
            }

            if (node.DIRECTION != MoveDirection.UP && node.CanMoveDown)
            {
                CloneMove(node, MoveDirection.DOWN);
            }

            if (node.DIRECTION != MoveDirection.DOWN && node.CanMoveUp)
            {
                CloneMove(node, MoveDirection.UP);
            }
        }
        /// <summary>
        /// Sao chép ra một node con của một node dựa vào hướng di chuyển
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="direction"></param>
        private void CloneMove(Node parent, MoveDirection direction)
        {
            // Tạo và cập nhật các giá trị cho node con
            Node m = parent.Clone();
            m.Move(direction);
            m.DIRECTION = direction;
            m.G++;

            // Nếu nút đã có trong Open
            if (Open.Contains(m.Label))
            {
                Node mOpen = Open[(long)m.Label];
                if (m.G < mOpen.G)
                {
                    m.Parent = parent;
                    m.Heuristic = Evaluate(m);
                    Open.Replace(m);
                }
            }
            else
            {
                m.Parent = parent;
                m.Heuristic = Evaluate(m);
                Open.Add(m);
            }

            // Nếu node đã có trong CLOSE
            if (closeQ.Contains(m.Label))
            {
                Node mClose = closeQ[(long)m.Label];
                if (m.G < mClose.G)
                {
                    m.Parent = parent;
                    m.Heuristic = Evaluate(m);
                    Open.Add(m);
                    closeQ.Remove(mClose);
                }
            }                                       
        }
        
        /// <summary>
        /// Hàm đánh giá
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private int Evaluate(Node matrix)
        {
            // Ô nằm sai vị trí bị cộng điểm bằng khoảng cách ô đó đến vị trí đúng   
            int score = 0;
            if (Game.SLOVE)
            {
                for (int i = 0; i < matrix.ArrayNode.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.ArrayNode.GetLength(0); j++)
                    {
                        int[] t = g.Goal_Even(matrix.ArrayNode[i, j]);
                        score += Math.Abs(t[0] - i) + Math.Abs(t[1] - j);
                    }
                }
            }
            else//N le
            {
                for (int i = 0; i < matrix.ArrayNode.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.ArrayNode.GetLength(0); j++)
                    {
                        int[] t = Goal.FindPosValue(matrix.ArrayNode[i, j], matrix.ArrayNode);//row, col of curent
                        int[] t1 = g.Goal_Odd(matrix.ArrayNode[i, j]);//row, col of goal
                        score += Math.Abs(t[0] - t1[0]) + Math.Abs(t[1] - t1[1]);
                    }
                }
            }
            return score;
        }
    }
}
