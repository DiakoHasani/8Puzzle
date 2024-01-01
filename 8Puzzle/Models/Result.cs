using _8Puzzle.Enums;
using _8Puzzle.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8Puzzle.Models
{
    public class Result
    {
        public IdsNode Node { get; }
        public State State { get; }
        public int Depth { get; }
        public int PathCost { get; }

        public Result(IdsNode node, State state)
        {
            Node = node;
            Depth = node.Depth;
            PathCost = node.PathCost;
            State = state;
        }
    }
}
