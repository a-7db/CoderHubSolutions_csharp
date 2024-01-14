namespace CA_word_repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = word_repeat("Hi", 2);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static string word_repeat(string word, int n)
        {
            // write your code here
            string output = "";

            for (int i = 0; i < n; i++)
            {
                if (i + 1 < n)
                {
                    output += word + " ";
                }
                else
                {
                    output += word;
                }
            }

            return output;
        }

    }
}
