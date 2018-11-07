using System;
using System.Collections.Generic;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ngrhhqbhnsipkcoqjyviikvxbxyphsnjpdxkhtadltsuxbfbrkof";
            System.Console.WriteLine(firstNotRepeatingCharacter(s));
        }
        /* Note: Write a solution that only iterates over the string once and uses O(1) additional memory,
        since this is what you would be asked to do during a real interview.

        Given a string s, find and return the first instance of a non-repeating character in it. 
        If there is no such character, return '_'. */

        static char firstNotRepeatingCharacter(string s) {
            //This dictionary uses the characters as the keys and the number of times they occor in the string as the value
            Dictionary<char,int> dict = new Dictionary<char,int>();
            //convert the string to a char array. I could iterate through the string but my brain works better with arrays
            char[] arr = s.ToCharArray();
            //holds the index of found repeating characters
            int index = -1;
            //the result to return
            char result;
            
            //iterate through the string
            for(int i = 0; i < arr.Length; i++){
                //if the dictionary contains the key, increment the value
                if(dict.ContainsKey(arr[i])){
                    dict[arr[i]] +=1;
                }
                //else create the key value pair
                else{
                    dict.Add(arr[i], 1);
                }
            }
            //after the dictionary is created scan for keys with values of 1
            foreach(KeyValuePair<char,int> kvp in dict){
                //Console.WriteLine("Key: {0}, Value: {1}",kvp.Key, kvp.Value);
                if(kvp.Value == 1){
                    //if index has not been set yet, set to the first found index of the char in the string
                    if(index == -1){
                        index = s.IndexOf(kvp.Key);
                    }
                    //if the index has been set check if the index if the testing char is less than the previously found char
                    else if(index > s.IndexOf(kvp.Key)){
                        index = s.IndexOf(kvp.Key);
                    }  
                }
            }
            //if index remains -1 then no non-repeating characters are in the string
            if(index == -1){
                result = '_';
            }
            //else set the result to the non-repeating char at the lowest index of the string
            else{
                result = s[index];
            }
            return result;

        }
    }
}
