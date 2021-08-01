using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            if (num == short.MaxValue + 1)
            {
                throw new OverflowException();
            }
            else
            {
                return (short)num;
            }
        }

        public static long FloatToLong(float num)
        {
            long newNum = Convert.ToInt64(num);
            return newNum;
        }
    }
}
