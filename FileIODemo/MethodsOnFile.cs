using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileIODemo
{
    class MethodsOnFile
    {
        public static void ReadAllText() 
        {
            string path = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\example.txt";
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }

        public static void FileCopy() 
        {
            string path = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\example.txt";
            string pathcopy = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\exampleCopy1.txt";
            File.Copy(path, pathcopy);
        }

        public static void DeleteFile() 
        {
            string path = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\exampleCopy.txt";
            File.Delete(path);
        }
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\example.txt";
            using(StreamReader sr =File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();

            }
        }
        public static void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\example.txt";
            using(StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine(".Net is Awesome");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
