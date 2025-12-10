namespace day4_part1;

public class Program
{
    public static void Main()
    {
        var lines = File.ReadAllLines("input.txt");
        char[,] grid = new char[lines.Length, lines[0].Length];
        int accessibleRolls = 0;
        
        for (int i = 0; i < lines.Length; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                grid[i, j] = lines[i][j];
            }
        }

        int[] dx = {-1, -1, -1, 0, 0, 1, 1, 1};
        int[] dy = {-1, 0, 1, -1, 1, -1, 0, 1};

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                char c = grid[i, j];
                if (c == '.') 
                    continue;
                
                int neighborCount = 0;
                for (int k = 0; k < 8; k++)
                {
                    int ni = i + dx[k];
                    int nj = j + dy[k];
                    
                    if (ni >= 0 && ni < grid.GetLength(0) && nj >= 0 && nj < grid.GetLength(1))
                    {
                        if (grid[ni, nj] == '@')
                            neighborCount++;
                    }
                }

                if (neighborCount < 4)
                    accessibleRolls++;
            }
        }
        
        Console.WriteLine($"Forklifts can access {accessibleRolls} rolls of paper.");
    }
}