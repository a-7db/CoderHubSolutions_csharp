namespace CA_gravity_flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] columns = [3, 2, 1, 2];
            var output = gravity_flip(columns);
            foreach (var num in output)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        public static int[] gravity_flip(int[] columns)
        {
            // write your code here
            Array.Sort(columns);
            return columns;
        }

    }
}
