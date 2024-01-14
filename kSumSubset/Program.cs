namespace CA_kSumSubset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool output = kSumSubset("2099-08-02T00:00:00");
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static bool kSumSubset(string dateString)
        {
            // write your code here
            DateTime my_date = DateTime.Parse(dateString);

            if (my_date.Date < DateTime.Now.Date)
            {
                if (my_date.Year < DateTime.Now.Year - 4)
                {
                    if (my_date.Year > DateTime.Now.Year - 200)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
