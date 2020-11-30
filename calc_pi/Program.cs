using System;

namespace calc_pi
{
    class Program
    {
        static void Main(string[] args)
        { 
            // PI is calculated more accurately with more cycles. 
            for (int i = 10; i < 100000000; i *= 10)
            {
                Console.WriteLine("PI: " + estimate_pi(i) + " Durchläufe: " + i); 
            }
        }


        static public double NextDouble(Random rand, double minValue, double maxValue)
        {
            return rand.NextDouble() * (maxValue - minValue) + minValue;
        }

        static public decimal estimate_pi(int n)
        {
            decimal num_point_circle = 0;
            decimal num_point_total = 0; 
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = NextDouble(rand, 0, 1);
                double y = NextDouble(rand, 0, 1);
                
                double distance = (x * x) + (y * y);
                if (distance <= 1.0)
                {
                    num_point_circle++;
                }
                num_point_total++;
            }

            return 4* (num_point_circle / num_point_total);
        }
    }
}
