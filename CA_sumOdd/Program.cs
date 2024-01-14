namespace CA_sumOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 9, 5, 4, 0];
            var output = sumOdd(arr);
            Console.WriteLine(output);

            Console.ReadKey();
        }
        public static int sumOdd(int[] arr)
        {
            // write your code here
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
    }
}
