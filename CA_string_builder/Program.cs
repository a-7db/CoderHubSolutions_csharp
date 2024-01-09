namespace CA_string_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = "3[a]2[bc]";
            string output = string_builder(expression);
            Console.WriteLine(output);
            Console.ReadKey();
        }


        public static string string_builder(string expression)
        {
            // write your code here
            Stack<int> numbers = new Stack<int>();
            Stack<char> letters = new Stack<char>();
            string temp = "", output = "";

            for (int i = 0; i < expression.Length; i++)
            {
                int count = 0;

                if (char.IsDigit(expression[i]))
                {
                    while (char.IsDigit(expression[i]))
                    {
                        count = count * 10 + expression[i] - '0';
                        i++;
                    }

                    i--;
                    numbers.Push(count);
                }

                else if (expression[i] == ']')
                {
                    temp = "";
                    count = 0;

                    if (numbers.Count > 0)
                    {
                        count = numbers.Peek();
                        numbers.Pop();
                    }

                    while (letters.Count > 0 &&
                            letters.Peek() != '[')
                    {
                        temp = letters.Peek() + temp;
                        letters.Pop();
                    }

                    if (letters.Count > 0 &&
                        letters.Peek() == '[')
                    {
                        letters.Pop();
                    }

                    
                    for (int j = 0; j < count; j++)
                    {
                        output = output + temp;
                    }

                    for (int j = 0; j < output.Length; j++)
                    {
                        letters.Push(output[j]);
                    }

                    output = "";
                }

                else if (expression[i] == '[')
                {
                    if (char.IsDigit(expression[i - 1]))
                    {
                        letters.Push(expression[i]);
                    }

                    else
                    {
                        letters.Push(expression[i]);
                        numbers.Push(1);
                    }
                }

                else
                {
                    letters.Push(expression[i]);
                }
            }

            while (letters.Count > 0)
            {
                output = letters.Peek() + output;
                letters.Pop();
            }

            return output;
        }

    }
}
