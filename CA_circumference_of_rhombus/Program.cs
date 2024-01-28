namespace CA_circumference_of_rhombus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = circumference_of_rhombus(12);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static double circumference_of_rhombus(double length)
        {
            // write your code here
            return length * 4;
        }

    }
}
