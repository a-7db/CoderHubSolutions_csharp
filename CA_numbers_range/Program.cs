namespace CA_numbers_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 4;
            var output = numbers_range(number);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static string numbers_range(int number)
        {
            // write your code here
            string output = "";
            for (int i = 0; i <= number; i++)
            {
                if (i < number)
                {
                    output += i + " ";
                }
                else
                {
                    output += i;
                }
            }

            return output;
        }
    }
}
