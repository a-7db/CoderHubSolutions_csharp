namespace CA_getPrimesBetween
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = getPrimesBetween(1, 10);
            foreach (var num in output)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        public static int[] getPrimesBetween(int a, int b)
        {
            // write your code here
            List<int> numbers = new List<int>();

            for (int i = a == 1 ? a + 1 : a; i <= b; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    numbers.Add(i);
                }
            }

            int[] output = numbers.ToArray();
            return output;
        }

    }
}
