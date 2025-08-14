using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q10
    {
        public static void Elements()
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            Console.WriteLine("common elemnets : ");
            for (int i = 0; i < dataset1.Length; i++)
                for (int j = 0; j < dataset2.Length; j++)
                {
                    if (dataset1[i] == dataset2[j])
                    {
                        Console.Write(dataset1[i] + " ");
                        break;
                    }
                }
        }
    }
}
