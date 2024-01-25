namespace CA_count_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = count_char("day", "d");
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static int count_char(string sentence, string ch)
        {
            // write your code here
            int counter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == Convert.ToChar(ch))
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
