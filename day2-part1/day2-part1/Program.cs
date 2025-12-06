namespace day2_part1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool IsDouble(long id)
            {
                string s = id.ToString();

                if (s.Length % 2 != 0)
                {
                    return false;
                }

                int half = s.Length / 2;
                string left = s.Substring(0, half);
                string right = s.Substring(half);

                return left == right;
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