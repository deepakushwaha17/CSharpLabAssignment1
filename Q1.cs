using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
     class Q1
    {
        public void Sum()
        {
            int sum = 0;
            int[] a = { 200, -150, 340, 500, -100 };
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum = "+sum);
        }
    }
}

