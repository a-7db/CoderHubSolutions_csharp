namespace CA_remove_duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [7, 8, 9, 7];
            var output = remove_duplicate(arr);
            foreach (var num in output)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        public static int[] remove_duplicate(int[] arr)
        {
            // write your code here
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < list.Count; j++)
                {
                    if (arr[i] == list[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    list.Add(arr[i]);
                }
            }

            int[] output = list.ToArray();

            return output;
        }

    }
}
