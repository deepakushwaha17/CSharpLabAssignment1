using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q8
    {
        public static void Grades()
        {
            int[] grades = { 56, 78, 89, 45, 67 };
            for (int i = 0; i < grades.Length; i++)
            {
                for (int j = 0; j < grades.Length - i - 1; j++)
                {
                    if (grades[j] > grades[j + 1])
                    {
                        int temp = grades[j];
                        grades[j] = grades[j + 1];
                        grades[j + 1] = temp;
                    }
                }
            }
            int secondSmallest = grades[1];
            Console.WriteLine("Second Smallest = "+secondSmallest);
        }
    }
}
