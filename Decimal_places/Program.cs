namespace CA_Decimal_places
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = Decimal_places("3.967");
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int Decimal_places(string num)
        {
            // write your code here
            int output = 0;

            if (num.Contains("."))
            {
                output = num.Substring(num.IndexOf('.') + 1).Length;
                return output;
            }
            else
            {
                return output;
            }
        }
    }
}
