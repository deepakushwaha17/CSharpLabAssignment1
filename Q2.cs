using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q2
    {
        public static void Score()
        {
            float sum = 0;
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            for (int i = 0; i < scores.Length; i++)
            {
                sum = sum + scores[i];
            }
            sum = sum / 5;
            Console.WriteLine("Score Sum = "+sum);
        }
    }
}
