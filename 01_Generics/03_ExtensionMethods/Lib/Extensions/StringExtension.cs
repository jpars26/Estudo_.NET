using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtension
    {
        public static string FirstToUpper(this String str)
        {
            string  First = str.Substring(0, 1);
            

            string Second = str.Substring(1);

            return First.ToUpper() + Second;
            
        }
    }
}
