using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Q7
    {
        public static void Book()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            int foundIndex = -1;
            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    foundIndex = i;
                    break;
                }
            }
            if (foundIndex != -1)
                Console.WriteLine("Book found at index:" + foundIndex);
            else
                Console.WriteLine("Book not fond in the system");
        }
    }
}
