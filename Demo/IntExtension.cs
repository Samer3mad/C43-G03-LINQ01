using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class IntExtension 
    {
        public static int Reverse (this int num)
        {
            int reversednum = 0, flag;
            while (num != 0)
            {
                flag = num % 10;
                reversednum = reversednum * 10 + flag;
                num /= 10;
            }
            return reversednum;
        }

        public static long Reverse(this long num)
        {
            long reversednum = 0, flag;
            while (num != 0)
            {
                flag = num % 10;
                reversednum = reversednum * 10 + flag;
                num /= 10;
            }
            return reversednum;
        }
    }
}
