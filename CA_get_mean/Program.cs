namespace CA_get_mean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [4, 1];
            var output = get_mean(arr);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static double get_mean(int[] arr)
        {
            // write your code here
            int count = arr.Length;
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double mean = sum / count;
            return mean;
        }

    }
}
