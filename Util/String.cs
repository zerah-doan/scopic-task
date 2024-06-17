using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScopicTask.Util
{
    public static class String
    {
        public static string GetCurrentTimeStamp()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public static string AddTimeStamp(this string str)
        {
            return str + GetCurrentTimeStamp();
        }
    }
}
