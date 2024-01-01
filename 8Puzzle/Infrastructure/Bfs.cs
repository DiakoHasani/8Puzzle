using _8Puzzle.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _8Puzzle.Infrastructure
{
    public class Bfs : Need, IBfs
    {
        private readonly IPrintService _printService;
        bool isGoalState = false;
        string strState;
        List<int[,]> solution;

        IPriorityQueue states_q;
        public static HashSet<string> visited;

        public Bfs(IPrintService printService)
        {
            N = 3;
            states_q = new PriorityQueue();
            solution = new List<int[,]>();
            visited = new HashSet<string>();
            _printService = printService;

            visited.Clear();
            solution.Clear();
        }

        private BfsNode GetNode(int[,] state, BfsNode parent, int x, int y)
        {
            BfsNode ch_nd = new BfsNode();
            ch_nd.X = x; ch_nd.Y = y;
            ch_nd.State = state;
            ch_nd.Level = parent.Level + 1;
            ch_nd.Cost = GetCost(state) + (int)Math.Log(ch_nd.Level);
            ch_nd.Parent = parent;
            return ch_nd;
        }

        public async Task Solve(int[,] c_state)
        {
            BfsNode root = CreateRoot(c_state);
            strState = ToString(c_state);
            states_q.Push(root); visited.Add(strState);

            while (!states_q.Empty() && !isGoalState)
            {
                BfsNode tmp = states_q.Pop();
                GetChild(tmp.State, tmp);
            }
            var counter = 1;
            for(int i = solution.Count - 1; i >= 0; i--)
            {
                await _printService.PrintBoard(solution[i]);
                _printService.PrintStats(counter++);
            }
            
        }

        private BfsNode CreateRoot(int[,] c_state)
        {
            var root = new BfsNode();
            root.Level = 0;
            root.State = c_state;
            root.Parent = null;
            root.Cost = GetCost(c_state);
            SetXY(root, c_state);
            return root;
        }

        private void SetXY(BfsNode root, int[,] c_state)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (c_state[i, j] == 0)
                    {
                        root.X = j;
                        root.Y = i;
                    }
        }

        private void GetChild(int[,] p, BfsNode tmp)
        {
            for (int i = 0; i < 4 && !isGoalState; i++)
            {
                if (IsSafe(tmp.Y + dy[i], tmp.X + dx[i]))
                {
                    int[,] c_state = new int[N, N];
                    Copy(c_state, tmp.State);
                    c_state[tmp.Y, tmp.X] = c_state[tmp.Y + dy[i], tmp.X + dx[i]];
                    c_state[tmp.Y + dy[i], tmp.X + dx[i]] = 0;
                    strState = ToString(c_state);
                    if (!visited.Contains(strState))
                    {
                        var ch_nd = GetNode(c_state, tmp, tmp.X + dx[i], tmp.Y + dy[i]);
                        visited.Add(strState); states_q.Push(ch_nd);
                        
                        if (IsGoal(c_state))
                        {
                            isGoalState = true;
                            var tmp_nd = ch_nd;
                            while (tmp_nd != null)
                            {
                                solution.Add(tmp_nd.State);
                                tmp_nd = tmp_nd.Parent;
                            }
                        }
                    }
                }
            }
        }
    }
}
