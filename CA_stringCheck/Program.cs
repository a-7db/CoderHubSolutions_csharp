namespace CA_stringCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] value = ["Code", "Code", "Code"];
            bool output = stringCheck(value);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static bool stringCheck(string[] value)
        {
            // write your code here
            int counter = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int w = 0; w < value.Length; w++)
                {
                    if (value[i] == value[w])
                    {
                        counter++;
                    }
                }
            }

            if (counter == value.Length)
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
