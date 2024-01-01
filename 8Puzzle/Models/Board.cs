using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Models
{
    public class Board
    {
        public int[,] Matrix { get; set; }

        public Board(int[,] matrix)
        {
            Matrix = matrix;
        }

        public Tuple<int, int> IndexOfZero()
        {
            int width = Matrix.GetLength(0);
            int height = Matrix.GetLength(1);

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    if (Matrix[x, y].Equals(0))
                    {
                        return Tuple.Create(x, y);
                    }
                }
            }

            return Tuple.Create(-1, -1);
        }

        public bool IsEqual(int[,] matrixToTest)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] != matrixToTest[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int result = 0;
            int shift = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    shift = (shift + 11) % 21;
                    result ^= (Matrix[i, j] + 1024) << shift;
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            var otherBoard = (Board)obj;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] != otherBoard.Matrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
