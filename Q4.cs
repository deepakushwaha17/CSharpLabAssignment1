using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q4
    {
        public static void Participants()
        {
            int[] participants = { 102, 215, 324, 453, 536 };
            int maleCount = 0;
            int femaleCount = 0;
            for (int i = 0; i < participants.Length; i++)
            {
                if (participants[i] % 2 == 0)
                {
                    maleCount++;
                }
                else
                {
                    femaleCount++;
                }
            }
            Console.WriteLine("number of males participants:" + maleCount);
            Console.WriteLine("number of females participants:" + femaleCount);

        }
    }
}
