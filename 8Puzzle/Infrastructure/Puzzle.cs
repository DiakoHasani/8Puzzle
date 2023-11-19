using _8Puzzle.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Infrastructure
{
    public class Puzzle : IPuzzle
    {
        private int[,] Board;
        private readonly Random _random;
        public Puzzle(int[,] Board)
        {
            this.Board = Board;
            _random = new Random();
        }
        public int GetInvCount()
        {
            var invCount = 0;
            for (int i = 0; i < 3 - 1; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (Board[j, i] > 0 && Board[j, i] > Board[i, j])
                    {
                        invCount++;
                    }
                }
            }

            return invCount;
        }

        public bool IsSolvable() => GetInvCount() % 2 == 0;

        public void Shuffle()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    int row = _random.Next(3);
                    int column = _random.Next(3);
                    int temp = Board[i, j];
                    Board[i, j] = Board[row, column];
                    Board[row, column] = temp;
                }
            }

            if (!IsSolvable())
            {
                Shuffle();
            }
        }

        public int[,] GetBoard()
        {
            return Board;
        }

        public void SetBoard(int[,] Board)
        {
            this.Board = Board;
        }
    }
}
