using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace SampleTest.DAL
{
    public class MyHelperClass
    {
        public static int GetPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
                return 0;

            int result = 0;
            if (password.Length > 7)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[0-9]").Success)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[\\@]").Success)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[a-z]").Success)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[A-Z]").Success)
                result += 1;

            return result;
        }
    }
}
