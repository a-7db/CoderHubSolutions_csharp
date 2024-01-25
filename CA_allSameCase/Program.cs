namespace CA_allSameCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = allSameCase("hello");
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static bool allSameCase(string word)
        {
            // write your code here
            bool isSameCase = false;

            if (char.IsUpper(word[0]))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    isSameCase = false;
                    if (char.IsUpper(word[i]))
                    {
                        isSameCase = true;
                    }

                    if (!isSameCase)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    isSameCase = false;
                    if (char.IsLower(word[i]))
                    {
                        isSameCase = true;
                    }

                    if (!isSameCase)
                    {
                        break;
                    }
                }
            }

            return isSameCase;
        }

    }
}
