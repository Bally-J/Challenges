using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeDecending
{
    public static class SecondAttempt
    {
        public static Boolean PalindromeDescendant(Int32 num)
        {
            //Retrieve all digits in the number
            Int32[] digits = GetDigits(num);
            
            return IsPalindromeDescendant(digits);
        }

        static Boolean IsPalindromeDescendant(Int32[] digits)
        {
            Int32[] decendantDigits;

            if (!IsPalindrome(digits))
            {
                if (!TryParseDecendant(digits, out decendantDigits))
                {
                    return false;
                }

                //use decendant
                return IsPalindromeDescendant(decendantDigits);
            }
            else
            {
                return true;
            }
        }

        static Boolean TryParseDecendant(Int32[] digits, out Int32[] decendantDigits)
        {
            decendantDigits = new int[digits.Length];
            
            //if we have odd number of digits we cant get a decendant according to the spec
            if (digits.Length % 2 != 0 || digits.Length <= 2)
            {
                return false;
            }
            else
            {
                Int32 count = 0;

                for (int i = 1; i < digits.Length; i += 2)
                {
                    Int32[] additionalDigs = GetDigits(digits[i] + digits[i - 1]);
                    for (int j = 0; j < additionalDigs.Length; j++)
                    {
                        decendantDigits[count] = additionalDigs[j];
                        count++;
                    }
                }

                //Removed 0s from array
                if (digits.Length > count)
                {
                    Int32[] cleanedReducedDigits = new Int32[count];
                    for (int i = 0; i < cleanedReducedDigits.Length; i++)
                    {
                        cleanedReducedDigits[i] = decendantDigits[i];
                    }

                    decendantDigits = cleanedReducedDigits;
                }

                return true;
            }
        }

        static Boolean IsPalindrome(Int32[] digits)
        {
            Int32 countdown = digits.Length;
            for (int i = 0; i < digits.Length; i++)
            {
                countdown--;
                if (digits[i] != digits[countdown])
                    return false;
            }

            return true;
        }

        static Int32[] GetDigits(Int32 number)
        {
            Int32 numOfDigits = number > 9 ? (Int32)Math.Floor(Math.Log10(number) + 1) : 1;
            Int32[] digits = new Int32[numOfDigits];

            for (int i = numOfDigits - 1; i >= 0; i--)
            {
                int remainder = number % 10;
                number = number / 10;
                digits[i] = remainder;
            }

            return digits;
        }

        //Test
        static Int32 GetReverse(Int32 number)
        {
            int reverseNum = 0;
            int forwardNum = number;
            while (forwardNum > 0)
            {
                int remainder = forwardNum % 10;
                reverseNum = (reverseNum * 10) + remainder;
                forwardNum = forwardNum / 10;
            }

            return reverseNum;
        }
    }
}
