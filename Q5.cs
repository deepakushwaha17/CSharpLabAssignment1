using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q5
    {
        public static void Reverse()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            int start = 0;
            int end = searchHistory.Length - 1;
            while (start < end)
            {
                int temp = searchHistory[start];
                searchHistory[start] = searchHistory[end];
                searchHistory[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine("Reversed search history");
            for (int i = 0; i < searchHistory.Length; i++)
            {
                Console.Write(searchHistory[i] + " ");
            }
        }
    }
}
