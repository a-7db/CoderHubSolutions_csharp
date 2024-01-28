namespace CA_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = [2, 4, 9, 23, 435];
            var output = average(values);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static double average(int[] values)
        {
            // write your code here
            double sum = 0;

            foreach (var i in values)
            {
                sum += i;
            }
            int count = values.Length;
            double avg = sum / count;
            return avg;
        }

    }
}
