using System;

namespace Balancepoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = {1,2,3,4,10};
            int[] arr2 = {10,4,3,2,1};
            int[] arr3 = {1,2,4,2,1};
            int[] arr4 = {-2,5,7,0,3};
            //System.Console.WriteLine(Balancepoint(arr3));
            System.Console.WriteLine(balanceIndex(arr4));
        }

        public static bool Balancepoint(int[] arr){
            if(arr.Length <= 1){
                return false;
            }
            int right = 0;
            int left = 0;
            for(int i = 0; i < arr.Length; i ++){
                right += arr[i];
                for(int j = arr.Length -1; j > i; j --){
                    left += arr[j];
                    
                }
                if(right == left){
                    System.Console.WriteLine(i);
                    return true;
                }
                else{
                    left = 0; 
                }
                             
            }
            return false;
        }

        
    public static int balanceIndex(int[] arr){
        if(arr.Length < 3){
            return -1;
        }
        int left = 0;
        int right = 0;
        for(int i = 0; i < arr.Length; i++){
            //left sum
            for(int j = 0; j < i; j++){
                left += arr[j];
            }
            //right sum
            for(int j = i + 1; j < arr.Length; j++){
                right += arr[j];
            }
            if(right == left){
                return i;
            }
            else{
                left = 0;
                right = 0;
            }
        }
        return -1;
    }

    }

}
