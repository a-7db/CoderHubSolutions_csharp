namespace CA_logical_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool output = logical_and(true, false);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static bool logical_and(bool a, bool b)
        {
            // write your code here
            if (a & b == true)
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
