namespace day3_part2;

public class Program
{
    public static void Main()
    {
        var input = File.ReadAllLines("input.txt");
        long total = 0;
        foreach (var line in input)
        {
            var digits = line.Select(c => c - '0').ToList();
            int toRemove = digits.Count - 12;

            List<int> stack = new();

            foreach (var d in digits)
            {
                while (stack.Count > 0 && toRemove > 0 && stack[^1] < d)
                {
                    stack.RemoveAt(stack.Count - 1);
                    toRemove--;
                }

                stack.Add(d);
            }

            var result = stack.Take(12);

            long value = 0;
            foreach (var d in result)
            {
                value = value * 10 + d;
            }
            
            total += value;
        }
        Console.WriteLine(total);
    }
}