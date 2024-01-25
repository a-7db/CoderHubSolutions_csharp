namespace CA_match_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = ["hello", "there", "word2"];
            string[] array2 = ["hello", "there", "word2"];
            var output = match_arrays(array1, array2);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static bool match_arrays(string[] array1, string[] array2)
        {
            // write your code here
            return array1.Length == array2.Length ? true : false;
        }

    }
}
