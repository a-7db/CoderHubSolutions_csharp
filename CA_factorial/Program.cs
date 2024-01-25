namespace CA_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = factorial(10);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static int factorial(int number)
        {
            // write your code here
            int output = 1;

            for (int i = number; i > 0; i--)
            {
                output *= i;
            }

            return output;
        }

    }
}
