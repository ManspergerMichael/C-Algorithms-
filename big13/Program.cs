using System;

namespace big13
{
    class Program
    {
        static void Main(string[] args)
        {
            void printTo255(){
                for (int i = 0; i < 256; i++)
                {
                    System.Console.WriteLine(i);
                }
            }
            void printOdd(){
                for (int i = 0; i < 256; i++)
                {
                    if(i % 2 != 0){
                        System.Console.WriteLine(i);
                    }
                }
            }
            void printSum(){
                int sum = 0;
                for (int i = 0; i < 256; i++)
                {
                    sum += i;
                    System.Console.WriteLine($"Number: {i} Sum: {sum}");
                }
            }
            void printArray(int[] arr){
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.WriteLine(arr[i]);
                }
            }
            void findMax(int[] arr){
                int max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if(max < arr[i]){
                        max = arr[i];
                    }
                }
                System.Console.WriteLine(max);
            }
            void findAvg(int[] arr){
                if(arr.Length < 2){
                    System.Console.WriteLine(arr[0]);
                }
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += i;
                }
                System.Console.WriteLine(sum / arr.Length);
            }
            printSum();
        }
    }
}
