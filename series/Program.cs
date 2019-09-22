using System;

namespace series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms in the series :");
            printSeries(int.Parse(Console.ReadLine()));
        }
        public static void printSeries(int n)
        {
            int print_count = 0;
            int start_count = 1;
            do
            {
                for (int i = 0; i < start_count; i++)
                {
                    Console.Write("{0},",start_count);
                    print_count += 1;
                    if (print_count == n)
                    {
                        break;
                    }
                }
                start_count += 1;
            } while (print_count < n);
        }
    }
}
