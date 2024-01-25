namespace CA_reverse_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = reverse_case("TeSt");
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static string reverse_case(string strParam)
        {
            // write your code here
            string output = "";
            for (int i = 0; i < strParam.Length; i++)
            {
                char val = strParam[i];
                if (char.IsUpper(val))
                {
                    output += val.ToString().ToLower();
                }
                else
                {
                    output += val.ToString().ToUpper();
                }
            }
            return output;
        }

    }
}
