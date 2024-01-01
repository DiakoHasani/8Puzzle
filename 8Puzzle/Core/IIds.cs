using _8Puzzle.Infrastructure;
using _8Puzzle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8Puzzle.Core
{
    public interface IIds
    {
        Task IterativeDeepeningSearch(int[,] problem);
        Result DepthLimitedSearch(int[,] problem, int depth);
        Result RecursiveDepthLimitedSearch(IdsNode node, int limit);
    }
}
