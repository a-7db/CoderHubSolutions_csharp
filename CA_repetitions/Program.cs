namespace CA_repetitions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = repetitions("AAAAAAAAAA");
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static int repetitions(string s)
        {
            // write your code here
            int top = 0;
            int i = 0;
            while (i < s.Length)
            {
                if (top < isDublicated(s, s[i], i))
                {
                    top = isDublicated(s, s[i], i);
                }
                i++;
            }

            return top;
        }

        public static int isDublicated(string s, char letter, int startIndex)
        {

            int counter = 0;
            for (int i = startIndex; i < s.Length; i++)
            {
                if (s[i] == letter)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
