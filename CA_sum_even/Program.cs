namespace CA_sum_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 9, 5, 4, 0];
            var output = sum_even(arr);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int sum_even(int[] arr)
        {
            // write your code here
            int sum = 0;
            List<int> even = new List<int>();

            foreach (var e in arr)
            {
                if (e % 2 == 0)
                {
                    even.Add(e);
                }
            }

            foreach (var num in even)
            {
                sum += num;
            }

            return sum;
        }

    }
}
