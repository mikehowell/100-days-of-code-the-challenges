using System;
using System.Collections.Generic;

namespace RomanNumerals2
{
    public class RomanNumerals
    {
        public string ArabicToRomanNumeral(int i)
        {
            if (i < 0 || i > 4999)
            {
                throw new ArgumentOutOfRangeException("Please enter a number value between 1 and 4999 inclusive.  {0} is not valid!", i.ToString());
            }

            if (i < 1) { return string.Empty; }

            if (i >= 1000) { return "M" + ArabicToRomanNumeral(i - 1000); }
            if (i >= 900) { return "CM" + ArabicToRomanNumeral(i - 900); }
            if (i >= 500) { return "D" + ArabicToRomanNumeral(i - 500); }
            if (i >= 400) { return "CD" + ArabicToRomanNumeral(i - 400); }
            if (i >= 100) { return "C" + ArabicToRomanNumeral(i - 100); }
            if (i >= 90) { return "XC" + ArabicToRomanNumeral(i - 90); }
            if (i >= 50) { return "L" + ArabicToRomanNumeral(i - 50); }
            if (i >= 40) { return "XL" + ArabicToRomanNumeral(i - 50); }
            if (i >= 10) { return "X" + ArabicToRomanNumeral(i - 10); }
            if (i >= 9) { return "IX" + ArabicToRomanNumeral(i - 9); }
            if (i >= 5) { return "V" + ArabicToRomanNumeral(i - 5); }
            if (i >= 4) { return "IV" + ArabicToRomanNumeral(i - 4); }
            if (i >= 1) { return "I" + ArabicToRomanNumeral(i - 1); }

            throw new ArgumentOutOfRangeException("Failure to convert {0} to Roman Numerals.", i.ToString());
        }

        public int RomanNumeralToArabic(string s)
        {
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && RomanNumeralMap[s[i]] < RomanNumeralMap[s[i + 1]])
                {
                    number -= RomanNumeralMap[s[i]];
                }
                else
                {
                    number += RomanNumeralMap[s[i]];
                }
            }
            return number;
        }

        private static Dictionary<char, int> RomanNumeralMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
    }
}
