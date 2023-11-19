using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Core
{
    public interface IPrintService
    {
        Task PrintBoard(int[,] board);
        void PrintStats(int iterations, int nodesGenerated, int depth);
        void SetTextPrintBoard(int row, int col, int value);
        void SetColorPrintBoard(int row, int col, int value);
    }
}
