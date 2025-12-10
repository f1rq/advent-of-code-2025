namespace day2_part2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool IsDouble(long id)
            {
                string s = id.ToString();
                int len = s.Length;

                for (var blockLength = 1; blockLength <= len / 2; blockLength++)
                {
                    if (len % blockLength != 0)
                    {
                        continue;
                    }

                    string block = s.Substring(0, blockLength);
                    int repeat = len / blockLength;

                    string newBlock = string.Join("", Enumerable.Repeat(block, repeat));

                    if (newBlock == s)
                    {
                        return true;
                    }
                }

                return false;
            }
            
            var input = File.ReadLines("input.txt");
            var pairs = input
                .SelectMany(line => line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                .ToArray();

            long total = 0;

            foreach (var pair in pairs)
            {
                var nums = pair.Split('-');
                long start = long.Parse(nums[0]);
                long end = long.Parse(nums[1]);

                for (long id = start; id <= end; id++)
                {
                    if (IsDouble(id))
                    {
                        total += id;
                    }
                }
            }
            
            Console.WriteLine($"Total: {total}");
        }
    }
}