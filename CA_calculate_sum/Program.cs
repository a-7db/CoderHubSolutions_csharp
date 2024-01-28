namespace CA_calculate_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 4];
            var output = calculate_sum(arr);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static int calculate_sum(int[] lst)
        {
            // write your code here
            int sum = 0;

            if (lst.Contains(7))
            {
                sum = 0;
            }
            else
            {
                foreach (var n in lst)
                {
                    sum += n;
                }
            }

            return sum;
        }

    }
}
