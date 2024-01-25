namespace CA_exponent_x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = exponent_x(1, 3);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static int exponent_x(int number, int exponent)
        {
            // write your code here
            int output = 1;

            for (int i = 0; i < exponent; i++)
            {
                output *= number;
            }
            return output;
        }
    }
}
