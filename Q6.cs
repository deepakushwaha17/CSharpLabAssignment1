using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q6
    {
        public static void Measurments()
        {
            int[] measurments = { 2, 4, 6, 8 };
            int factor = 3;
            for (int i = 0; i < measurments.Length; i++)
            {
                measurments[i] = measurments[i] * factor;
            }
            Console.WriteLine("adjusted measurments : ");
            for (int i = 0; i < measurments.Length; i++)
            {
                Console.Write(measurments[i] + " ");
            }
        }
    }
}
