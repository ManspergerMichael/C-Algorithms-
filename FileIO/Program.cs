using System;
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
                        System.Console.WriteLine(line.Substring(0,1));
                    }
                    if(column == 2)
                    {
                        System.Console.WriteLine(line.Substring(2,1));
                    }
                    
                }
            }
        }
    }
}
