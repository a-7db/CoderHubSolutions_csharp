namespace CA_cone_volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = cone_volume(1.3d, 5.2d);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static double cone_volume(double radius, double height)
        {
            // write your code here
            double output = 0;
            output = 3.14 / 3 * (radius * radius) * height;

            return output;
        }

    }
}
