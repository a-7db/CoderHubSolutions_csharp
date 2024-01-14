namespace CA_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = search("cloud", "u");
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int search(string word, string character)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.Parse(character) == word[i])
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
