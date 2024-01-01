namespace _8Puzzle.Infrastructure
{
    public abstract class Need
    {
        public int[] dy = { 1, 0, -1, 0 };
        public int[] dx = { 0, -1, 0, 1 };

        public int N { set; get; }
        public int[,] goal = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
        public int[,] initial_state;

        public int[,] GetDestination()
        {
            int[,] c_state = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    c_state[i, j] = (i * N + j + 1) % (N * N);
            return c_state;
        }

        public void Copy(int[,] c_state, int[,] state)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    c_state[i, j] = state[i, j];
        }

        public bool IsGoal(int[,] state)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (state[i, j] != goal[i, j])
                        return false;
            return true;
        }

        public string ToString(int[,] state)
        {
            string ans = "";
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    ans += (char)(48 + state[i, j]);
            return ans;
        }

        public int GetCost(int[,] state)
        {
            int cost = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (state[i, j] != goal[i, j])
                        cost++;
            return cost;
        }
        public bool IsSafe(int x, int y)
        {
            return x >= 0 && x < N && y >= 0 && y < N;
        }

        public void SetGoal(int[,] c_state)
        {
            goal = c_state;
        }

        public void Set_State(int[,] c_state)
        {
            initial_state = c_state;
        }
    }
}
