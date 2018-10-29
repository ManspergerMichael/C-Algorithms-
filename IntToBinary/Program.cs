using System;
using System.Collections.Generic;

namespace IntToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = {6156,128,12486,7196,2032};
            IntToBinary(arr);

        }
        public static void IntToBinary(int[] array){
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                while(num > 0){
                    if(num % 2 == 0){
                        //Console.Write(0);
                        result.Add(0);
                    }
                    else{
                        //Console.Write(1);
                        result.Add(1);
                    }
                    num = num / 2;

                }
            result.Reverse();
            foreach (int bit in result)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            result.Clear();
            } 
        }
    }
}
