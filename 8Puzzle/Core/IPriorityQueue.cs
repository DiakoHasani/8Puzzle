using _8Puzzle.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Core
{
    public interface IPriorityQueue
    {
        BfsNode Pop();
        bool Empty();
        void Push(BfsNode node);
    }
}
