namespace CA_sum_two_smallest_nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 5, 6, 7, 3];
            int output = sum_two_smallest_nums(arr);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int sum_two_smallest_nums(int[] arr)
        {
            // write your code here
            Array.Sort(arr);

            return arr[0] + arr[1];
        }

    }
}
