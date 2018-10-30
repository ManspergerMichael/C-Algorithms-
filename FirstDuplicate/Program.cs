using System;
using System.Collections.Generic;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //call function(s) with input here
        }
        /* Given an array a that contains only numbers in the range from 1 to a.length,
        find the first duplicate number for which the second occurrence has the minimal index. 
        In other words, if there are more than 1 duplicated numbers, return the number for which
        the second occurrence has a smaller index than the second occurrence of the other number does. 
        If there are no such elements, return -1. */


        //My first attempt works perfectly except for very large data sets. O(n^2) > 3 seconds
        int firstDuplicate(int[] a) {
            //I set the index to the last index of the array to work with the decision logic below.
            int index = a.Length;
            //if no duplicates are found return -1;
            int value = -1;
            //compare each value of the array with each other value
            for(int i = 0; i< a.Length; i++){
                for(int j = i + 1;j < a.Length; j++){
                    //if a duplicate is found...
                    if(a[i] == a[j]){
                        //and the index is less than the index of the previously found duplicate...
                        if(index > j){
                            //set index to j and value to a[i], a[j] would also work.
                            index = j;
                            value = a[i];
                        }
                    }
                }
            }
            return value;
        }
        //This function uses a HashSet, accessing is O(1) time
        //so the algorithim iterates through the array at most once
        //O(n).
        //This method finds the first duplicate and returns that value without multiple 
        //traversals through the array
        int firstDuplicateHash(int[] a) {
        HashSet<int> dict = new HashSet<int>();
        for(var i = 0; i < a.Length; i++){
            //if dict contains a[i]
            if(dict.Contains(a[i])){
                return a[i];
            }
            else{
                dict.Add(a[i]);
            }
        }
        return -1;
        }
    }
}
