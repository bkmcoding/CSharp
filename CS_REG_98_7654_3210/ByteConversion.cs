using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS_REG_98_7654_3210
{
    internal static class ByteConversion
    {
        // Method that runs whenever called upon that takes the radio options and user input and 
        // returns the requested conversion data size
        public static double CheckConversion(double userInput, bool[] ConvertFromRb, bool[] ConvertToRb)
        {
            // creation of basic variables for calculation
            double result = userInput;
            int FromIndex = 0;
            int ToIndex = 0;

            // sets the FromIndex into the specific radio button index in order for later calculation
            for (int index = 0; index < ConvertFromRb.Length; index++)
            {
                if (ConvertFromRb[index])
                {
                    FromIndex = index;
                    break;
                }

            }

            // sets the ToIndex into the specific radio button index in order for later calculation
            for (int index = 0; index < ConvertToRb.Length; index++)
            {
                if (ConvertToRb[index])
                {
                    ToIndex = index;
                    break;
                }

            }

            // Calculates the difference in result based on the difference of indexes between the radio
            // button conversions
            int difference = FromIndex - ToIndex;
            if (difference > 0)
            {
                for (int index = 0; index < difference; index++)
                {
                    result *= 1024;
                }
            } 
            if (difference < 0)
            {
                for (int index = 0; index > difference; index--)
                {
                    result /= 1024;
                }
            }

            result = Math.Round(result, 15);

            return result;

        }
    }
}
