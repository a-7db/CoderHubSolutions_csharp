namespace CA_raduis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = raduis(130.55d);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static double raduis(double circumference)
        {
            // write your code here
            double radius = circumference / (2 * 3.14);

            return radius;
        }

    }
}
