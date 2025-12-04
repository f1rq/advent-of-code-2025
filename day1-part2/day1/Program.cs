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
                int start = pos;
                int startMod = ((start % 100) + 100) % 100;
                
                switch (direction)
                {
                    case "L":
                    {
                        int tozero = startMod == 0 ? 100 : startMod;
                        if (amount >= tozero)
                        {
                            zeros += 1 + (amount - tozero) / 100;
                        }
                        pos -= amount;
                        pos = (pos % 100 + 100) % 100;
                        Console.WriteLine(pos);
                        continue;
                    }
                    case "R":
                    {
                        int tozero = (100 - startMod) % 100;
                        if (tozero == 0) tozero = 100;
                        if (amount >= tozero)
                        {
                            zeros += 1 + (amount - tozero) / 100;
                        }
                        pos += amount;
                        pos = (pos % 100 + 100) % 100;
                        Console.WriteLine(pos);
                        continue;
                    }
                }
            }
            Console.WriteLine($"Final position: {pos}");
            Console.WriteLine($"Number of times at position 0: {zeros}");
        }
    }
}