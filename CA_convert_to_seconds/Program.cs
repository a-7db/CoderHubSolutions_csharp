namespace CA_convert_to_seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = convert_to_seconds(6);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int convert_to_seconds(int hours)
        {
            // write your code here
            int seconds = hours * 3600;
            return seconds;
        }
    }
}
