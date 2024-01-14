namespace CA_isEvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = isEvenOrOdd(1);
            Console.WriteLine(output);

            Console.ReadKey();
        }
        public static string isEvenOrOdd(int num)
        {
            // write your code here
            return num % 2 == 0 ? "even" : "odd";
        }
    }
}
