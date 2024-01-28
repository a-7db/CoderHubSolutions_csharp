namespace CA_cumulative_addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements_array = [5, 1, 2, 4, 9, 10, 200];
            var output = cumulative_addition(elements_array);
            Console.WriteLine($"[{output[0]}, {output[1]}]");

            Console.ReadLine();
        }

        public static int[] cumulative_addition(int[] elements_array)
        {
            // write your code here
            int sum = 0;

            foreach (var item in elements_array)
            {
                sum += item;
            }

            int[] output = { sum, elements_array.Length };

            return output;
        }

    }
}
