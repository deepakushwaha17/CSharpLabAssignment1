using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q9
    {
        public static void Unique()
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            List<int> uniqueIds = new List<int>();
            for (int i = 0; i < ids.Length; i++)
            {
                if (!uniqueIds.Contains(ids[i]))
                {
                    uniqueIds.Add(ids[i]);
                }
            }
            Console.WriteLine("unigue ids : ");
            foreach (int id in uniqueIds)
            {
                Console.WriteLine(id + " ");
            }
        }
    }
}
