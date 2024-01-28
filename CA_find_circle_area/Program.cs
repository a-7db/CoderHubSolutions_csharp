namespace CA_find_circle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = find_circle_area(5.4d);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static double find_circle_area(double radius)
        {
            // write your code here
            double area = (radius * radius) * 3.14;
            return area;
        }

    }
}
