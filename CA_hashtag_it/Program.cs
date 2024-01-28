namespace CA_hashtag_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] my_array = ["stay_home", "coronavirus", "Saudi_Arabia"];
            var output = hashtag_it(my_array);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static string hashtag_it(string[] my_array)
        {
            // write your code here
            string output = "";

            for (int i = 0; i < my_array.Length; i++)
            {
                if (i + 1 < my_array.Length)
                {
                    output += my_array[i].Insert(0, "#") + " ";
                }
                else
                {
                    output += my_array[i].Insert(0, "#");
                }
            }
            return output;
        }

    }
}
