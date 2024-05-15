using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal static class Questions
    {
        public static void substring(string str)
        {
            for (int start = 0; start < str.Length; start++)
            {
                for (int end = start+1; end <= str.Length; end++) 
                {
                    var substr = str.Substring(start, end-start);
                    Console.WriteLine(substr);
                }
            }
        }
    }
}
