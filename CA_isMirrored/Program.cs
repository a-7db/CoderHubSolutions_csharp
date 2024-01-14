namespace CA_isMirrored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = isMirrored(11);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static bool isMirrored(int num)
        {
            // write your code here
            string num2 = num.ToString();
            string output = "";

            for (int i = num2.Length - 1; i >= 0; i--)
            {
                output += num2[i];
            }

            if (Int32.Parse(output) == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
