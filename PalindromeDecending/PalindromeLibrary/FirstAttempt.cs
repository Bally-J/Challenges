using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeDecending
{
    public static class FirstAttempt
    {
        public static Boolean PalindromeDescendant(string value)
        {
            if (String.IsNullOrEmpty(value))
                return false;


            Int32 lengthOfNumber = value.Length;
            Int32 midPoint = Convert.ToInt32(Math.Floor(lengthOfNumber / 2f));
            Int32 lastNum = lengthOfNumber - 1;

            for (int i = 0; i < midPoint; i++)
            {

                if (value[i].ToString() != value[lastNum].ToString())
                {
                    string newValue;
                    if (lengthOfNumber > 2 && TryParseDescendant(value, out newValue))
                    {
                        return PalindromeDescendant(newValue);
                    }

                    return false;
                }

                lastNum--;
            }

            return true;
        }

        private static Boolean TryParseDescendant(String value, out string result)
        {
            char[] valueList = value.ToCharArray();
            Int32 lengthOfNumber = valueList.Length;
            Int32 midPoint = Convert.ToInt32(Math.Floor(lengthOfNumber / 2f));
            Boolean isEven = lengthOfNumber % 2 == 0;
            result = "";
            if (isEven)
            {
                for (int i = 0; i < lengthOfNumber; i = i + 2)
                {
                    int num = Convert.ToInt32(valueList[i].ToString()) + Convert.ToInt32((valueList[i + 1].ToString()));
                    result += num.ToString();
                }
            }
            else
            {
                return false;
            }

            return true;
        }


    }
}
