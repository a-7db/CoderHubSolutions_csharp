namespace CA_divisible_by_five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = divisible_by_five(3);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static bool divisible_by_five(int num)
        {
            // write your code here
            if (num % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
