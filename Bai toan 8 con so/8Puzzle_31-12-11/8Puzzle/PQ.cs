using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Puzzle
{
    class PQ
    {
        private List<Node> list;
        private HashSet<int> idList;

        public PQ()
        {
            list = new List<Node>();
            idList = new HashSet<int>();
        }

        public Node this[long ID]
        {
            get
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].Label == ID)
                        return list[i];
                return null;
            }
        }

        public Node this[int pos]
        {
            get { return list[pos]; }
            set { list[pos] = value; }
        }

        public void Add(Node item)
        {
            if (!idList.Contains(item.Label))
            {
                idList.Add(item.Label);

                for (int i = 0; i < list.Count; i++)
                {

                    if (item.F <= list[i].F)
                    {
                        list.Insert(i, item);
                        return;
                    }
                }
                list.Add(item);//thêm vào cuối
            }
        }

        public void Clear()
        {
            list.Clear();
            idList.Clear();
        }

        public void Remove(Node item)
        {
            idList.Remove(item.Label);
            list.Remove(item);
        }

        public int Count
        { 
            get { return list.Count; } 
        }

        public void Replace(Node m)
        {
            Remove(m);
            Add(m);
        }

        public bool Contains(int ID)
        {
            return idList.Contains(ID);
        }
    }
}
