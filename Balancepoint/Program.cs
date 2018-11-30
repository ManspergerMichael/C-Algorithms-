using System;

namespace Balancepoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //test arrays
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
            //sums of left and right
            int right = 0;
            int left = 0;
            //iterate through array, at each iteration add to right sum
            for(int i = 0; i < arr.Length; i ++){
                right += arr[i];
                //start at end of array, add elements until i index is reached
                for(int j = arr.Length -1; j > i; j --){
                    left += arr[j];
                    
                }
                //if sums are equal return true
                if(right == left){
                    System.Console.WriteLine(i);
                    return true;
                }
                //else reset left sum and iterate i
                else{
                    left = 0; 
                }
                             
            }
            //if no balance index is found return false
            return false;
        }

        
    public static int balanceIndex(int[] arr){
        //if the array has less than 3 elements, return -1
        if(arr.Length < 3){
            return -1;
        }
        //sums for the left and right
        int left = 0;
        int right = 0;
        for(int i = 0; i < arr.Length; i++){
            //left sum, add all elements from the beginning of the array to the i index
            for(int j = 0; j < i; j++){
                left += arr[j];
            }
            //right sum, add all elements from the i index to the end of the aray
            for(int j = i + 1; j < arr.Length; j++){
                right += arr[j];
            }
            //if sums are equal return the balence index
            if(right == left){
                return i;
            }
            //otherwise reset sums to 0 and iterate i index
            else{
                left = 0;
                right = 0;
            }
        }
        //if no balance point found return -1
        return -1;
    }

    }

}
