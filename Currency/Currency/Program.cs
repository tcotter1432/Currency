using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Currency
{
    class Program
    {
        public static double calculateSmallest(double one, double two, double three)
        {
            if (two < one && two < three)
            {
                return two;
            }
            else if (three < one && three < two)
            {
                return three;
            }
            else
            {
                return one;
            }
        }
        public static double calculateBiggest(double one, double two, double three)
        {
            if (two > one && two > three)
            {
                return two;
            }
            else if (three > one && three > two)
            {
                return three;
            }
            else
            {
                return one;
            }
        }
        static void Main(string[] args)
        {
            double inOne, inTwo, inThree, average, smallest, largest, total;
            Console.WriteLine("Please input three $$$ amounts.");
            inOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A second...");
            inTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And a third...");
            inThree = Convert.ToDouble(Console.ReadLine());

            total = inOne + inTwo + inThree;
            average = total / 3;
            smallest = calculateSmallest(inOne, inTwo, inThree);
            largest = calculateBiggest(inOne, inTwo, inThree);
            Console.WriteLine("Average: " + average.ToString("F") + "\n Smallest: " + smallest + "\n Largest: " + largest);


            Console.WriteLine("Total: \n US: " + total.ToString("C", new CultureInfo("en-US"))+"\n Swedish: "+ total.ToString("C", new CultureInfo("sv-SE")) + "\n Japanese: " + total.ToString("C", new CultureInfo("ja-JP")) + "\n Thai: " + total.ToString("C", new CultureInfo("th-TH")));
            Console.ReadKey();
        }
    }
}
