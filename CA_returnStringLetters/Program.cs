namespace CA_returnStringLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = returnStringLetters("Ahmed", "Mohammad");
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int returnStringLetters(string string1, string string2)
        {
            // write your code here
            return string1.Length >= string2.Length ? string1.Length : string2.Length;
        }

    }
}
