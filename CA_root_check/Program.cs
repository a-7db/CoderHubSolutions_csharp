namespace CA_root_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = root_check(25, 5);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static int root_check(double sqr, int num)
        {
            // write your code here
            return num * num == sqr ? num : 0;
        }

    }
}
