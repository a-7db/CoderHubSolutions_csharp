namespace CA_convertPercent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double output = convertPercent("30%");
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static double convertPercent(string percentage)
        {
            // write your code here
            double num = Convert.ToDouble(percentage.Remove(percentage.IndexOf('%')));

            double output = num / 100;
            return output;
        }

    }
}
