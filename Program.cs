using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sales = "1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0";
            Console.WriteLine("Longest sequences of days without sale: " + GetLongestNoSaleSequence(sales));
        }
        
        static int GetLongestNoSaleSequence(string sales)
        {
            string[] dailySales = sales.Split(',');
            int currentCount = 0;
            int maxCount = 0;

            foreach (var sale in dailySales)
            {
                if (sale == "0")
                {
                    currentCount++;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }
    } 
}
            