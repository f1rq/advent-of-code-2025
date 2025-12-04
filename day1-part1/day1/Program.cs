namespace day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int pos = 50;
            int zeros = 0;
            foreach (var line in File.ReadAllLines("input.txt"))
            {
                string direction = line[0].ToString();
                int amount = int.Parse(line.Substring(1));

                switch (direction)
                {
                    case "L":
                        pos -= amount;
                        pos = (pos % 100 + 100) % 100;
                        if (pos == 0)
                            zeros++;
                        Console.WriteLine(pos);
                        continue;
                    case "R":
                        pos += amount;
                        pos = (pos % 100 + 100) % 100;
                        if (pos == 0)
                            zeros++;
                        Console.WriteLine(pos);
                        continue;
                }
            }
            Console.WriteLine($"Final position: {pos}");
            Console.WriteLine($"Number of times at position 0: {zeros}");
        }
    }
}