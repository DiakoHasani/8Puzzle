using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8Puzzle.Infrastructure
{
    public class BfsNode
    {
        public int Level { get; set; }
        public int Cost { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int[,] State { get; set; }
        public BfsNode Parent { get; set; }
    }
}
