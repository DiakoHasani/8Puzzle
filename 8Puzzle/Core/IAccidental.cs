using _8Puzzle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Core
{
    public interface IAccidental
    {
        Task Start();
        (int,int) FindZeroPosition();
        List<Move> MovementAcess(int row,int col);
        bool LeftAccess(int col);
        bool TopAccess(int row);
        bool RightAccess(int col);
        bool BottomAccess(int row);
        bool CheckFinishedPuzzle();
        Move GetRandomMovement(List<Move> moves);
        void ChangePosition(Move move,int row,int col);
        List<Move> GetRandomMovementData(List<Move> moves);
    }
}
