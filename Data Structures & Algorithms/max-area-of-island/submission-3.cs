public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var max = 0;

        for (int i=0 ; i<grid.Length; i++)
        {
            for (int j=0 ; j<grid[i].Length; j++)
                if (grid[i][j] == 1)
                {
                    var len = dfs(i, j, grid);
                    max = Math.Max(max, len);
                }
        }

        return max;
    }

    private int dfs(int i, int j, int[][] grid)
    {
        var queue = new Queue<(int, int)>();
        queue.Enqueue((i, j));

        var directions = new List<(int, int)>
        {
            (1, 0), (0, 1),
            (-1, 0), (0, -1)
        };

        var lenght = 1;
        while (queue.Count > 0)
        {
            var (r, c) = queue.Dequeue();
            Console.WriteLine("Found {0} {1}", r, c);

            foreach (var (dr, dc) in directions)
            {
                // in bounds
                var cr = r + dr;
                var cc = c + dc;

                if (cr >= 0 && cr < grid.Length &&
                    cc >= 0 && cc < grid[cr].Length &&
                    grid[cr][cc] == 1)
                {
                    lenght++;
                    queue.Enqueue((cr, cc));
                    grid[cr][cc] = 0;
                }
            }

            grid[r][c] = 0;
        }

        return lenght;
    }
}
