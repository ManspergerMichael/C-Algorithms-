using System;
using System.Collections.Generic;

namespace sequentialDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            sequentialDigits(10,30);
        }
        static void sequentialDigits(int lowPoint, int highPoint){
            bool flag = true;
            List<int> result = new List<int>();
            
            for(int i = lowPoint; i < highPoint; i++){
                int test = 0;
                flag = true;
                int num = i;
                //check each digit of the number
                while(num > 0){
                    test = num % 10;
                    num = num / 10;
                    System.Console.WriteLine("test: "+ test+ "num: " + num);
                    if(num % 10 != test - 1){
                        flag = false;
                        break;
                    }
                }
                if(flag == true){
                    //System.Console.WriteLine(i);
                    result.Add(i);
                }
            }
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
                
            }
            
        }
    }
}
