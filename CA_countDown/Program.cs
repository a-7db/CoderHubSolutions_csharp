namespace CA_countDown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            var output = countDown(number);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static string countDown(int number)
        {
            // write your code here
            string countDown = "";

            for (int i = number; i > -1; i--)
            {
                if (i != 0)
                {
                    countDown += i + " ";
                }
                else
                {
                    countDown += i;
                }
            }

            return countDown;
        }

    }
}
