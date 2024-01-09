namespace CA_deleteLastChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "CoderHub";
            string output = deleteLastChar(word);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static string deleteLastChar(string word)
        {
            String newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i == word.Length - 1)
                {
                    newWord = word.Remove(word.Length - 1);
                }
            }
            return newWord;
        }
    }
}
