﻿using System;
using System.Collections.Generic;
using System.IO;
namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ReadFile("./TestFile.csv", 2);
        }
        public static void ReadFile(String fileName, int column)
        {
            Dictionary<String,int> dict = new Dictionary<String,int>();
            try
            {
                String st = System.IO.File.ReadAllText(fileName);
                //System.Console.WriteLine(st);
            }
            catch( Exception e )
            {
                System.Console.WriteLine("The File Could Not Be Read");
                System.Console.WriteLine(e.Message);
            }
            String file = System.IO.File.ReadAllText(fileName);
            using (StringReader reader = new StringReader(file))
            {
                String line;
                line = reader.ReadLine();
                
                while((line = reader.ReadLine()) != null)
                {
                    if(column == 1)
                    {
                        if(dict.ContainsKey(line.Substring(0,1)))
                        {
                            dict[line.Substring(0,1)] += 1;
                        }
                        else{
                            dict.Add(line.Substring(0,1), 1);
                        }
                        //System.Console.WriteLine(line.Substring(0,1));
                    }
                    if(column == 2)
                    {
                        if(dict.ContainsKey(line.Substring(2,0)))
                        {
                            dict[line.Substring(2,0)] += 1;
                        }
                        else{
                            dict.Add(line.Substring(2,0), 1);
                        }
                        System.Console.WriteLine(line.Substring(2,1));
                    }
                    
                }

            }
            foreach(KeyValuePair<String,int> item in dict)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}