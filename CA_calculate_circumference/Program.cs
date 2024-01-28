namespace CA_calculate_circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = calculate_circumference(2);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static double calculate_circumference(double radius)
        {
            // write your code here
            double calc = 2 * Math.PI * radius;
            return calc;
        }

    }
}
