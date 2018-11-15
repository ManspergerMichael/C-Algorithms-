using System;
using System.Collections.Generic;

namespace AreSimmular
{
    class Program
    {
        /* Two arrays are called similar if one can be obtained from another by 
        swapping at most one pair of elements in one of the arrays.

        Given two arrays a and b, check whether they are similar. */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static bool areSimilar(int[] a, int[] b) {
            Dictionary<int, int> dict = new Dictionary<int,int>();
            //if count greater than 2, then more than one swap is required
            int count = 0;
            for(int i = 0; i < a.Length; i++){
                
                if(dict.ContainsKey(a[i])){
                    dict[a[i]] = dict[a[i]] + 1;
                }
                else{
                    dict.Add(a[i], 1);
                }
                if(dict.ContainsKey(b[i])){
                    dict[b[i]] = dict[b[i]] + 1;
                }
                else{
                    dict.Add(b[i], 1);
                }
                if(a[i] != b[i]){
                    count ++;
                }
            
            }
            foreach(KeyValuePair<int,int> item in dict){
                    if(item.Value != 2){
                        return false;
                    }
                }
            
            if(count > 2){
                return false;
            }
            else{
                return true;
            }
            
        }

    }
}
