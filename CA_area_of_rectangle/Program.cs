namespace CA_area_of_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = area_of_rectangle(9, 8);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int area_of_rectangle(int width, int height)
        {
            // write your code here
            int area = width * height;
            return area;
        }
    }
}
