using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int result = 0;
            string operater = x.ToString().Replace('-',' ').Trim();
            string reverseResult = "";
            bool IsNegative = x < 0;

            for (int i = operater.Length-1; i >= 0  ; i--)
            {
                reverseResult += operater[i];
            }

            result = TryConvertToInt(reverseResult);

            if (IsNegative)
            {
                result = result * -1;
            }

            return result;
        }


        private int TryConvertToInt(string nums)
        {
            int result;
            try
            {
                result = Convert.ToInt32(nums);
            }
            catch (OverflowException)
            {
                result = 0;
            }

            return result;
        }
    }
}
