using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;       // 1 byte yer kaplar
            sbyte c = 5;      // signed byte 1 byte yer kaplar
            short s =2;       //2 byte yer kaplar
            ushort us = 5;    //unsigned 2 byte yer kaplar

            //int16 i = 2;      //2 byte
            int i = 2;        //4 byte
            //int32 i32 =12304; //4 byte
            Int64 i64;        // 8 byte

            long l;            //8 byte
            float f;           //4 byte
            double d;          //8 byte
            decimal de;        //16 byte

            char ch;           //2 byte
            string str;

            bool b1;          // true or false

            DateTime dateTime= DateTime.Now;

            object o1;   // classlarin base i

            string ss = string.Empty;
            string s1 = "Murat";
            string s2 = "UTLU";
            string s3 = s1 + " " + s2;   // Strings can concade!

        }
    }
}
