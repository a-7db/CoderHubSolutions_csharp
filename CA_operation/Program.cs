namespace CA_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = operation(6, 7);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static string operation(int num1, int num2)
        {
            // write your code here
            string type = "";

            if (num1 + num2 == 24)
            {
                type = "added";
            }
            else if (num1 / num2 == 24)
            {
                type = "divided";
            }
            else if (num1 * num2 == 24)
            {
                type = "multiplied";
            }
            else if (num1 - num2 == 24)
            {
                type = "subtracted";
            }

            else
            {
                type = "None";
            }

            return type;
        }

    }
}
