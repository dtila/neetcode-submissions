public class Solution {
    public int OrangesRotting(int[][] grid) {
        var level = 0;
        var fresh = 0;
        var queue = new Queue<(int, int)>();
        
        for (int i=0 ; i<grid.Length; i++)
        {
            for (int j=0 ; j<grid[i].Length ; j++)
            {
                if (grid[i][j] == 1)
                    fresh++;

                if (grid[i][j] == 2)
                    queue.Enqueue((i, j));
            }
        }

        var directions = new List<(int, int)>
        {
            (0, 1), (1, 0), (-1, 0), (0, -1)
        };

        while (queue.Count > 0)
        {
            var len = queue.Count;
            var rotten = false;
            for (int i=0; i < len; i++)
            {
                var (or, oc) = queue.Dequeue();
                foreach (var (dr, dc) in directions)
                {
                    var r = or + dr;
                    var c = oc + dc;

                    var bounds = 
                        r >= 0 && r < grid.Length &&
                        c >= 0 && c < grid[r].Length;

                    if (bounds && grid[r][c] == 1)
                    {
                        queue.Enqueue((r, c));
                        grid[r][c] = 2;
                        fresh--;
                        rotten = true;
                    }
                }
            }

            if (rotten)
                level++;
        }
        
        return fresh == 0 ? level : -1;
    }
}
