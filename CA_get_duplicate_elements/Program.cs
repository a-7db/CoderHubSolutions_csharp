namespace CA_get_duplicate_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 3, 2, 3];
            int[] output = get_duplicate_elements(arr);
            
            foreach (int i in output)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static int[] get_duplicate_elements(int[] arr)
        {
            // write your code here
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int m = 0; m < arr.Length - 1; m++)
                {
                    if (arr[i] == arr[m] && i != m && !list.Contains(arr[i]))
                    {
                        list.Add(arr[i]);
                    }
                }
            }
            int[] output = list.ToArray();
            return output;
        }
    }
}
