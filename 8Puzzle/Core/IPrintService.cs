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
        void PrintStats(params int[] values);
        void SetTextPrintBoard(int row, int col, int value);
        void SetColorPrintBoard(int row, int col, int value);
    }
}
