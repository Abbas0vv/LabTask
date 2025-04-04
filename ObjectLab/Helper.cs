using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjectLab
{
    public static class Helper
    {
        public static bool CheckGroupNo(string groupNo)
        {
            return Regex.IsMatch(groupNo, @"^[A-Z]{2}[0-9]{3}$");
        }

        public static bool CheckFullName(string fullName)
        {
            return Regex.IsMatch(fullName, @"^[A-Z][a-z]+ [A-Z][a-z]+$");
        }
    }
}
