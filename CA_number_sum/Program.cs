namespace CA_number_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = number_sum(3);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int number_sum(int num)
        {
            // write your code here
            int output = 0;

            for (int i = 1; i <= num; i++)
            {
                output += i;
            }

            return output;
        }

    }
}
