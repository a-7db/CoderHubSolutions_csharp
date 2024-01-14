namespace CA_input_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = input_type("hello");
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static string input_type(string value)
        {
            // write your code here
            if (char.IsLetter(value[0]))
            {
                return "string";
            }
            else
            {
                if (value.Contains('.'))
                {
                    return "double";
                }
                else
                {
                    return "integer";
                }
            }
        }

    }
}
