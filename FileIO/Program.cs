using System;
using System.Collections.Generic;
using System.IO;
namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ReadFile("./TestFile.csv", 1);
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
                        //System.Console.WriteLine(line.Substring(0,1));
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
                        if(dict.ContainsKey(line.Substring(2,1)))
                        {
                            dict[line.Substring(2,1)] += 1;
                        }
                        else{
                            dict.Add(line.Substring(2,1), 1);
                        }
                        //System.Console.WriteLine(line.Substring(2,1));
                    } 
                }
            }
            //print duplicates
            System.Console.WriteLine("These Duplicates where found");
            using (StringReader reader = new StringReader(file))
            {
                String line = reader.ReadLine();
                String check;
                while((line = reader.ReadLine()) != null)
                {
                    line = reader.ReadLine();
                    if(column == 1){
                        check = line.Substring(0,1);
                        if( dict[check] > 1)
                        {
                            System.Console.WriteLine(line);
                        }
                    }
                    else if(column == 2)
                    {
                        check = line.Substring(2,1);
                        if( dict[check] > 1)
                        {
                            System.Console.WriteLine(line);
                        }
                    }
                }
                
            }
            

          
            foreach(KeyValuePair<String,int> item in dict)
            {
                System.Console.WriteLine("Key: {0}, Value: {1}",item.Key,item.Value);
            }
           
        }
    }
}
