namespace CA_left_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = left_digit("Welcome2back");
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static int left_digit(string strParam)
        {
            // write your code here
            int digit = 0;

            for (int i = 0; i < strParam.Length; i++)
            {
                if (char.IsDigit(strParam[i]))
                {
                    digit = (int)char.GetNumericValue(strParam[i]);
                    break;
                }
            }

            return digit;
        }

    }
}
