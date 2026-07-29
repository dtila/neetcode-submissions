public class Solution {
    public int NumIslands(char[][] grid) {
        var num = 0;

        for (int i=0 ; i<grid.Length ; i++)
        {
            for (int j=0 ; j<grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    num++;
                    dfs(i, j, grid);
                }
            }
        }

        return num;
    }

    public void dfs(int i, int j, char[][] grid)
    {
        var queue = new Queue<(int, int)>();
        queue.Enqueue((i, j));

        while (queue.Count > 0)
        {
            var (r, c) = queue.Dequeue();
            if (r < 0 || r >= grid.Length || 
                c < 0 || c >= grid[r].Length)
                continue;

            if (grid[r][c] is '0' or 'X')
                continue;

            grid[r][c] = 'X';

            queue.Enqueue((r + 1, c));
            queue.Enqueue((r, c + 1));
            queue.Enqueue((r - 1, c));
            queue.Enqueue((r, c - 1));
        }
    }    
}
