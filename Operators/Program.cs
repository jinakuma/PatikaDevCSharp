using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            num1 += 20;
            num1 *= 2;
            num1 /= 4;

            bool issuccess = true;
            bool isCompleted = false;
            if (issuccess&&isCompleted)
            Console.WriteLine("Perfect");
            if(isCompleted||issuccess)
            Console.WriteLine("Great!");
            if(isCompleted  && !issuccess)
            Console.WriteLine("Fine!");

            int a  = 3;
            int b  = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            bool sonuc1 = a>b;
            Console.WriteLine(sonuc1);
            bool sonuc2 = a==b;
            Console.WriteLine(sonuc2);
            bool sonuc3 = a!=b;
            Console.WriteLine(sonuc3);


        }
    }
}
