using _8Puzzle.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8Puzzle.Infrastructure
{
    public class PriorityQueue : IPriorityQueue
    {
        List<BfsNode> nodes = new List<BfsNode>();

        private void Swap(BfsNode a, BfsNode b, int idx, int small_idx)
        {
            nodes[idx] = b; nodes[small_idx] = a;
        }

        private void MinHeapify(int idx)
        {
            int left = 2 * idx + 1, right = 2 * idx + 2, small_idx = idx;
            small_idx = left < nodes.Count
                && nodes[left].Cost < nodes[idx].Cost ? left : idx;
            small_idx = right < nodes.Count
                && nodes[right].Cost < nodes[small_idx].Cost ? right : small_idx;
            if (small_idx != idx)
            {
                Swap(nodes[idx], nodes[small_idx], idx, small_idx);
                MinHeapify(small_idx);
            }
        }

        public bool Empty()
        {
            return nodes.Count == 0;
        }

        public BfsNode Pop()
        {
            if (nodes.Count > 0)
            {
                var nd = nodes[0];
                nodes[0] = nodes[nodes.Count - 1];
                nodes.RemoveAt(nodes.Count - 1);
                MinHeapify(0);
                return nd;
            }
            return null;
        }

        public void Push(BfsNode node)
        {
            nodes.Add(node);
            Update(nodes.Count - 1);
        }

        private void Update(int idx)
        {
            while (idx != 0 && nodes[(idx - 1) / 2].Cost > nodes[idx].Cost)
            {
                Swap(nodes[idx], nodes[(idx - 1) / 2], idx, (idx - 1) / 2);
                idx = (idx - 1) / 2;
            }
        }
    }
}
