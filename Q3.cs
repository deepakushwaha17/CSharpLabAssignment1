using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q3
    {
        public static void MaxPrice()
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int maxPrice = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > maxPrice)
                {
                    maxPrice = prices[i];
                }
                else
                {
                }
            }
            Console.WriteLine("MaxPrice = "+maxPrice);
        }
    }
}
