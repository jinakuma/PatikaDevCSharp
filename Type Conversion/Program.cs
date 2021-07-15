using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Implicit Type Conversion

            //  Implicit conversions don't require special syntax to be invoked and can occur in a variety of situations,
            //  for example, in assignments and methods invocations. 
            //  Predefined C# implicit conversions always succeed and never throw an exception. 
            //  User-defined implicit conversions should behave in that way as well. 
            //  If a custom conversion can throw an exception or lose information, define it as an explicit conversion
            

            //Explicit Type Conversion
            int x  =4;
            byte y = (byte)x;  // casting

            float v = 10.3f;
            byte v = (byte)v;
            Console.WriteLine("v: {0}", v);
            
            //Convert Method
            
            float ff = 16.25f;
            int cc = Convert.ToInt32(ff);
            Console.WriteLine("cc: {0}", cc);

        }

        public static void ParseMethod()
        {
            string text1 = "10";
            string text2 = "10.25";

            int num1;
            double double1;

            num1 = Int32.Parse(text1);
            double1 = Double.Parse(text2);
        }
    }
}
