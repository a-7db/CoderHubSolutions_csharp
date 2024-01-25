namespace CA_mergeAndOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = [1, 2];
            int[] array2 = [3, 4];
            var output = mergeAndOrder(array1, array2);
            foreach(var num in output)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        public static int[] mergeAndOrder(int[] array1, int[] array2)
        {
            // write your code here
            int[] array3 = new int[array1.Length + array2.Length];
            int index = 0;


            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
                index++;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array3[i + index] = array2[i];
            }
            Array.Sort(array3);
            return array3;
        }

    }
}
