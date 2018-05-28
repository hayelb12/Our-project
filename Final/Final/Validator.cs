using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public static class Validator
    {
        public static bool userLegal(string user)
        {
            if (user.Length > 20 || user.Length < 4)
                return false;
            char first = user[0];

            if ((first > 'z' || first < 'a') && (first > 'Z' || first < 'A'))
                return false;

            for (int i = 1; i < user.Length; i++)
            {
                first = user[i];
                if ((first > 'z' || first < 'a') && (first > 'Z'|| first < 'A') && (first > '9' || first < '1'))
                    return false;
            }

            return true;
        }

        public static bool passLegal(string pass)
        {
            if (pass.Length > 20 || pass.Length < 4)
                return false;

            bool hasLow = false, hasUpper = false, hasNumber = false;

            for (int i = 0; i < pass.Length; i++)
            {
                char first = pass[i];
                if (first >= 'a' && first <= 'z')
                {
                    hasLow = true;
                    continue;
                }
                else if(first >='A' && first <='z')
                {
                    hasUpper = true;
                }
                else if(first >= '0' && first <='9')
                {
                    hasNumber = true;
                }
                else
                {
                    return false;//no special characters
                }
                    
            }


            return (hasLow && hasUpper && hasNumber);
        }
    }

}
