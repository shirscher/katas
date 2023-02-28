namespace number_of_islands;

public class Solution 
{
    public int NumIslands(char[][] grid) {
        int islands = 0;
        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[row].Length; col++) {
                if (grid[row][col] != 'V' && grid[row][col] == '1') {
                    TraverseIsland(grid, row, col);
                    islands++;
                }
            }
        }

        return islands;
    }

    private void TraverseIsland(char[][] grid, int row, int col) {
        grid[row][col] = 'V';

        // Enqueue all neighbors
        if (row> 0 && grid[row- 1][col] == '1' && grid[row- 1][col] != 'V')
        {
            TraverseIsland(grid, row - 1, col);
        }
        if (row< grid.Length - 1 && grid[row+ 1][col] == '1' && grid[row+ 1][col] != 'V')
        {
            TraverseIsland(grid, row + 1, col);
        }
        if (col > 0 && grid[row][col - 1] == '1' && grid[row][col - 1] != 'V')
        {
            TraverseIsland(grid, row, col - 1);
        }
        if (col < grid[row].Length - 1 && grid[row][col + 1] == '1' && grid[row][col + 1] != 'V')
        {
            TraverseIsland(grid, row, col + 1);
        }
    }
}