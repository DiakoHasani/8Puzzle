using _8Puzzle.Core;
using _8Puzzle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Infrastructure
{
    public class Accidental : IAccidental
    {
        private readonly IPrintService _printService;
        private Random _random;

        private int turn;
        private bool isAnimate;
        private int[,] _board;
        public Accidental(IPrintService printService,
            int[,] board,
            bool isAnimate)
        {
            _printService = printService;
            _board = board;
            _random = new Random();
            turn = 0;
            this.isAnimate = isAnimate;
        }

        public (int, int) FindZeroPosition()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    if (_board[i, j] == 0)
                    {
                        return (i, j);
                    }
                }
            }
            throw new Exception("not found zero in board");
        }

        public List<Move> MovementAcess(int row, int col)
        {
            var moves = new List<Move>();
            if (LeftAccess(col))
            {
                moves.Add(Move.Left);
            }
            if (TopAccess(row))
            {
                moves.Add(Move.Top);
            }
            if (RightAccess(col))
            {
                moves.Add(Move.Right);
            }
            if (BottomAccess(row))
            {
                moves.Add(Move.Down);
            }
            return moves;
        }

        public async Task Start()
        {
            var finishedPuzzle = false;

            while (!finishedPuzzle)
            {
                (int zeroPositionRow, int zeroPositionCol) = FindZeroPosition();
                finishedPuzzle = CheckFinishedPuzzle();
                if (finishedPuzzle)
                    continue;

                var moves = MovementAcess(zeroPositionRow, zeroPositionCol);
                if (moves.Count == 0)
                    continue;

                ChangePosition(GetRandomMovement(moves), zeroPositionRow, zeroPositionCol);
                if (isAnimate)
                {
                    await _printService.PrintBoard(_board);
                    _printService.PrintStats(turn);
                }
                turn++;
            }
            if (!isAnimate)
            {
                await _printService.PrintBoard(_board);
                _printService.PrintStats(turn);
            }
        }

        public bool LeftAccess(int col)
        {
            return (col - 1) >= 0;
        }

        public bool TopAccess(int row)
        {
            return (row - 1) >= 0;
        }

        public bool RightAccess(int col)
        {
            return (col + 1) > 0 && (col + 1) <= 2;
        }

        public bool BottomAccess(int row)
        {
            return (row + 1) > 0 && (row + 1) <= 2;
        }

        public bool CheckFinishedPuzzle()
        {
            var value = 0;
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    if (_board[i, j] != value++)
                        return false;
                }
            }
            return true;
        }

        public Move GetRandomMovement(List<Move> moves)
        {
            if (moves.Count == 1)
                return moves.First();

            var values = GetRandomMovementData(moves);
            return values[_random.Next(values.Count)];
        }

        public void ChangePosition(Move move, int row, int col)
        {
            switch (move)
            {
                case Move.Left:
                    _board[row, col] = _board[row, col - 1];
                    _board[row, col - 1] = 0;
                    break;
                case Move.Top:
                    _board[row, col] = _board[row - 1, col];
                    _board[row - 1, col] = 0;
                    break;
                case Move.Right:
                    _board[row, col] = _board[row, col + 1];
                    _board[row, col + 1] = 0;
                    break;
                case Move.Down:
                    _board[row, col] = _board[row + 1, col];
                    _board[row + 1, col] = 0;
                    break;
            }
        }

        public List<Move> GetRandomMovementData(List<Move> moves)
        {
            var values = new List<Move>();
            var position = 0;
            for (int i = 0; i < moves.Count * 5; i++)
            {
                values.Add(moves[position++]);
                if (position > moves.Count - 1)
                {
                    position = 0;
                }
            }
            return values;
        }
    }
}
