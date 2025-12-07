public class Solution {
    public int OrangesRotting(int[][] grid) {
        int min = 0;
        int good = 0;
        Queue<(int i, int j)> rotten = new Queue<(int i, int j)>();
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 2) {
                    rotten.Enqueue((i, j));
                } else if (grid[i][j] == 1) {
                    good++;
                }
            } 
        } 

        rotten.Enqueue((-1, -1));

        while (rotten.Count > 1) {
            var cell = rotten.Dequeue();

            if(cell.i == -1) {
                min++;
                rotten.Enqueue((-1, -1));
                continue;
            }

            if(cell.i > 0 && grid[cell.i-1][cell.j] == 1)
            {
                rotten.Enqueue((cell.i-1,cell.j));
                grid[cell.i-1][cell.j] = 2;
                good--;
            }
            if(cell.j > 0 && grid[cell.i][cell.j-1] == 1)
            {
                rotten.Enqueue((cell.i,cell.j-1));
                grid[cell.i][cell.j-1] = 2;
                good--;
            }
            if(cell.i < grid.Length-1 && grid[cell.i+1][cell.j] == 1)
            {
                rotten.Enqueue((cell.i+1,cell.j));
                grid[cell.i+1][cell.j] = 2;
                good--;
            }
            if(cell.j < grid[0].Length-1 && grid[cell.i][cell.j+1] == 1)
            {
                rotten.Enqueue((cell.i,cell.j+1));
                grid[cell.i][cell.j+1] = 2;
                good--;
            }

        }

        return (good == 0) ? min : -1;
    }
}