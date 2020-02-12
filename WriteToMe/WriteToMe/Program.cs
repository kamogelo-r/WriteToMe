using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = File.ReadAllLines("Financial Jargon.txt").Length; //counts number of lines in file
            Console.WriteLine(line);

            ReadFile();
            WriteToFile();

            Console.Read();
        }

        private static void ReadFile()
        {
            //using (var reader = new StreamReader("Financial Jargon.txt"))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        string[] parts = line.Split(',');

            //        foreach (var item in parts)
            //        {
            //            Console.WriteLine(item);
            //        }
            //    }
            //}

            //OR

            string file = File.ReadAllText("Financial Jargon.txt");

            Console.WriteLine(file);
        }

        private static void WriteToFile()
        {
            using (var writer = new StreamWriter(@"C:\Users\kamogelo.ramokgadi\Documents\Visual Studio 2015\Projects\Basics\WriteToMe\WriteToMe\bin\Debug\Example.txt"))
            {
                while (writer != null)
                {
                    writer.WriteLine("Hello World");
                }
            }
        }
    }
}
