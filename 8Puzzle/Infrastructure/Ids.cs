using _8Puzzle.Core;
using _8Puzzle.Enums;
using _8Puzzle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Infrastructure
{
    public class Ids : IIds
    {
        private int _iterations;
        private int _nodesGenerated;

        private readonly IPrintService _printService;
        public Ids(IPrintService printService)
        {
            _printService = printService;
        }

        public Result DepthLimitedSearch(int[,] problem, int depth)
        {
            return RecursiveDepthLimitedSearch(new IdsNode(problem), depth);
        }

        public async Task IterativeDeepeningSearch(int[,] problem)
        {
            for (int depth = 0; depth < int.MaxValue; depth++)
            {
                Result result = DepthLimitedSearch(problem, depth);
                if (result.State == State.Result)
                {
                    _printService.PrintStats(_iterations, _nodesGenerated, result.Node.Depth);
                    foreach (var item in result.Node.PathToSolution())
                    {
                        await _printService.PrintBoard(item.Board);
                    }

                    return;
                }
            }
        }

        public Result RecursiveDepthLimitedSearch(IdsNode node, int limit)
        {
            _iterations++;
            if (IdsNode.GoalTest(node.Board))
            {
                return new Result(node, State.Result);
            }
            else if (node.Depth >= limit)
            {
                return new Result(node, State.Cutoff);
            }
            else
            {
                node.Expand();
                foreach (IdsNode child in node.Childs)
                {
                    _nodesGenerated++;
                    Result result = RecursiveDepthLimitedSearch(child, limit);
                    if (result.State == State.Result)
                    {
                        return result;
                    }
                }
            }

            return new Result(node, State.Failure);
        }
    }
}
