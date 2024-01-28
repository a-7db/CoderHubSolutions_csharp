namespace CA_countdown02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = countdown(10);
            foreach (var num in output)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        public static int[] countdown(int num)
        {
            // write your code here
            List<int> list = new List<int>();

            for (int i = num; i > 0; i = i - 3)
            {
                if (i % 2 == 0 && i != num)
                {
                    list.Add(i);
                }
            }

            int[] output = list.Count != 0 ? list.ToArray() : new int[1];
            Array.Sort(output);
            output[0] = list.Count != 0 ? list[list.Count - 1] : 0;

            return output;
        }

    }
}
