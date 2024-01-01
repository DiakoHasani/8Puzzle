using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Models
{
    public class StateModel : IComparable<StateModel>
    {
        private int manhatanDistance;
        public Board CurrentBoard { get; set; }
        public StateModel Parent { get; set; }
        public string LastMove { get; set; }
        public int SearchDepth { get; set; }

        public StateModel(Board currentBoard, StateModel parent, string lastMove, int searchDepth)
        {
            CurrentBoard = currentBoard;
            Parent = parent;
            LastMove = lastMove;
            SearchDepth = searchDepth;
        }

        public int ManhatanDistance()
        {
            var matrix = CurrentBoard.Matrix;
            manhatanDistance = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var num = matrix[i, j];

                    switch (num)
                    {
                        case 1: manhatanDistance += Math.Abs(0 - i) + Math.Abs(1 - j); break;
                        case 2: manhatanDistance += Math.Abs(0 - i) + Math.Abs(2 - j); break;
                        case 3: manhatanDistance += Math.Abs(1 - i) + Math.Abs(0 - j); break;
                        case 4: manhatanDistance += Math.Abs(1 - i) + Math.Abs(1 - j); break;
                        case 5: manhatanDistance += Math.Abs(1 - i) + Math.Abs(2 - j); break;
                        case 6: manhatanDistance += Math.Abs(2 - i) + Math.Abs(0 - j); break;
                        case 7: manhatanDistance += Math.Abs(2 - i) + Math.Abs(1 - j); break;
                        case 8: manhatanDistance += Math.Abs(2 - i) + Math.Abs(2 - j); break;

                        default:
                            break;
                    }
                }
            }

            return manhatanDistance;
        }

        public StateModel MoveZeroToTheLeft(int x, int y)
        {
            if (y == 0)
            {
                return null;
            }

            var clonedStateModel = Clone();

            var temp = clonedStateModel.CurrentBoard.Matrix[x, y - 1];
            clonedStateModel.CurrentBoard.Matrix[x, y - 1] = 0;
            clonedStateModel.CurrentBoard.Matrix[x, y] = temp;
            return clonedStateModel;
        }

        public StateModel MoveZeroToTheRight(int x, int y)
        {
            if (y == (CurrentBoard.Matrix.Length / 3) - 1)
            {
                return null;
            }

            var clonedStateModel = Clone();

            var temp = clonedStateModel.CurrentBoard.Matrix[x, y + 1];
            clonedStateModel.CurrentBoard.Matrix[x, y + 1] = 0;
            clonedStateModel.CurrentBoard.Matrix[x, y] = temp;
            return clonedStateModel;
        }

        public StateModel MoveZeroUp(int x, int y)
        {
            if (x == 0)
            {
                return null;
            }

            var clonedStateModel = Clone();

            var temp = clonedStateModel.CurrentBoard.Matrix[x - 1, y];
            clonedStateModel.CurrentBoard.Matrix[x - 1, y] = 0;
            clonedStateModel.CurrentBoard.Matrix[x, y] = temp;
            return clonedStateModel;
        }

        public StateModel MoveZeroDown(int x, int y)
        {
            if (x == (CurrentBoard.Matrix.Length / 3) - 1)
            {
                return null;
            }

            var clonedStateModel = Clone();

            var temp = clonedStateModel.CurrentBoard.Matrix[x + 1, y];
            clonedStateModel.CurrentBoard.Matrix[x + 1, y] = 0;
            clonedStateModel.CurrentBoard.Matrix[x, y] = temp;
            return clonedStateModel;
        }

        public StateModel Clone()
        {
            var newMatrix = new int[3, 3];

            for (int i = 0; i < CurrentBoard.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < CurrentBoard.Matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = CurrentBoard.Matrix[i, j];
                }
            }

            var clonedBoard = new Board(newMatrix);

            return new StateModel(clonedBoard, Parent, LastMove, SearchDepth);
        }

        public int CompareTo(StateModel other)
        {
            var thisValue = this.ManhatanDistance();
            var otherValue = other.ManhatanDistance();

            if (thisValue < otherValue)
            {
                return 1;
            }
            else if (thisValue > otherValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
