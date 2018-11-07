using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //reverse a given integer
            int num = -5;
            System.Console.WriteLine(reverseInt(num));
        }

        public static int reverseInt(int num){
            int reverse = 0;
            int integer = num;
            bool isNeg = false;
            if(integer < 0){
                integer = integer * -1;
                isNeg = true;
            }
            while(integer > 0){
                int lastDigit = integer % 10;
                reverse = (reverse * 10) + lastDigit;
                integer = integer / 10;
            }
            if(isNeg == true){
                reverse = reverse * -1;
            }
            return reverse;

        }
    }
}
