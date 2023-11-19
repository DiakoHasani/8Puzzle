using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Core
{
    public interface IPuzzle
    {
        int GetInvCount();
        bool IsSolvable();
        void Shuffle();
        int[,] GetBoard();
        void SetBoard(int[,] Board);
    }
}
