using System;

namespace DataTypes
{
    class Program
    {
        // Explore immutable values
        // Constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "3 July 1989";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be {0}", myBirthday);
            Console.Read();

            // Challenge to create variables for each data type
            // Boolean - True or false
            bool myBoolean = true;
            // SByte - -128 -> 127
            sbyte mySByte = 127;
            // Short - -32768 -> 32767
            short myShort = 32766;
            // Int
            int myInteger = 5;
            // Long
            long myLong = 1234567890L;
            // Float
            float myFloat = 32.46F;
            // Double
            double myDouble = 32.46D;
            // Decimal
            decimal myDecimal = 53005.25M;
            // Char
            char myChar = 'a';
            // String
            string myString = "This is a string";
        }
    }
}
