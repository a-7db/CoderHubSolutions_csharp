namespace CA_delete_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [3, 2, 4, 88];
            var output = delete_element_in_array(arr, 2);
            
            foreach ( var item in output ) 
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static int[] delete_element_in_array(int[] arr, int index)
        {
            // write your code here
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    list.Add(arr[i]);
                }
            }
            int[] output = list.ToArray();
            return output;
        }

    }
}
