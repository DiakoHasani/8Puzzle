using _8Puzzle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.Core
{
    public interface IAStar
    {
        Task Solve(StateModel state);
    }
}
