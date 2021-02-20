using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteNumber = 255;

            short shortNumber = byteNumber;
            int intNumber = shortNumber;
            float floatNumber = intNumber;

            floatNumber = -1.5f;

            intNumber = (int)floatNumber;

            uint uintNumber = (uint)floatNumber;

            uintNumber = 55111u;

            byteNumber = (byte) uintNumber;

            
        }
    }
}
