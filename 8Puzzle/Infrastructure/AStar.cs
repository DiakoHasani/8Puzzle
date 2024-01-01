using _8Puzzle.Core;
using _8Puzzle.Models;
using C5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Infrastructure
{
    public class AStar : IAStar
    {
        private readonly IPrintService _printService;
        public AStar(IPrintService printService)
        {
            GoalState = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8, } };
            _printService = printService;
        }
        private int[,] GoalState { get; set; }
        private int MaxFringeSize { get; set; }
        private int MaxSearchDepth { get; set; }
        private int NodesExpanded { get; set; }

        private async Task PrintState(StateModel state)
        {
            var items = new List<Board>();
            while (state != null)
            {
                items.Add(state.CurrentBoard);
                state = state.Parent;
            }

            for (int i = items.Count - 1; i >= 0; i--)
            {
                await _printService.PrintBoard(items[i].Matrix);
            }
        }

        private List<StateModel> GenerateChildrenStates(StateModel currentState, int x, int y)
        {
            var children = new List<StateModel>();

            var rightState = currentState.MoveZeroToTheRight(x, y);
            if (rightState != null)
            {
                rightState.LastMove = "right";
                rightState.Parent = currentState;
                rightState.SearchDepth++;
                children.Add(rightState);
            }

            var leftState = currentState.MoveZeroToTheLeft(x, y);
            if (leftState != null)
            {
                leftState.LastMove = "left";
                leftState.Parent = currentState;
                leftState.SearchDepth++;
                children.Add(leftState);
            }

            var downState = currentState.MoveZeroDown(x, y);
            if (downState != null)
            {
                downState.LastMove = "down";
                downState.Parent = currentState;
                downState.SearchDepth++;
                children.Add(downState);
            }

            var upState = currentState.MoveZeroUp(x, y);
            if (upState != null)
            {
                upState.LastMove = "up";
                upState.Parent = currentState;
                upState.SearchDepth++;
                children.Add(upState);
            }

            return children;
        }

        public async Task Solve(StateModel state)
        {
            var visited = new System.Collections.Generic.HashSet<Board>();
            var queue = new IntervalHeap<StateModel>();

            queue.Add(state);
            visited.Add(state.CurrentBoard);

            while (queue.Count > 0)
            {
                if (queue.Count > MaxFringeSize)
                {
                    MaxFringeSize = queue.Count;
                }

                state = queue.DeleteMax();

                if (state.CurrentBoard.IsEqual(GoalState))
                {
                    await PrintState(state);
                    break;
                }

                NodesExpanded++;

                var zeroXAndY = state.CurrentBoard.IndexOfZero();
                var zeroX = zeroXAndY.Item1;
                var zeroY = zeroXAndY.Item2;
                var children = GenerateChildrenStates(state, zeroX, zeroY);

                for (var i = children.Count - 1; i >= 0; i--)
                {
                    var currentChild = children[i];
                    if (!visited.Contains(currentChild.CurrentBoard))
                    {
                        queue.Add(currentChild);
                        visited.Add(currentChild.CurrentBoard);

                        if (currentChild.SearchDepth > MaxSearchDepth)
                        {
                            MaxSearchDepth = currentChild.SearchDepth;
                        }
                    }
                }
            }
        }
    }
}
