namespace day3_part1;

public class Program
{
    public static void Main()
    {
        var input = File.ReadAllLines("input.txt");
        int total = 0;
        foreach (var line in input)
        {
            var digits = line.ToCharArray();
            int max = 0;
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = i+1; j < line.Length; j++)
                {
                    int d1= digits[i] - '0';
                    int d2= digits[j] - '0';
                    int value = d1 * 10 + d2;

                    if (value > max)
                    {
                        max = value;
                    }
                }
            }
            total += max;
        }
        Console.WriteLine(total);
    }
}