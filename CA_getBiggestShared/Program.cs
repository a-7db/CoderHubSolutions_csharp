namespace CA_getBiggestShared
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = [1, 2, 4, 5];
            int[] b = [3, 4, 7, 11];
            var output = getBiggestShared(a, b);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int getBiggestShared(int[] a, int[] b)
        {
            // write your code here
            Array.Sort(a);
            Array.Sort(b);
            int output = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int c = 0; c < b.Length; c++)
                {
                    if (a[i] == b[c])
                    {
                        output = a[i];
                    }
                }
            }

            return output;
        }

    }
}
