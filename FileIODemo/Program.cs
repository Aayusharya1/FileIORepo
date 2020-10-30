using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //FileExists();
            //ReadAllLines();
            //MethodsOnFile.ReadAllText();
            //MethodsOnFile.FileCopy();
            //MethodsOnFile.DeleteFile();
            //MethodsOnFile.ReadFromStreamReader();
            MethodsOnFile.WriteUsingStreamWriter();

            SerializationDeserialization serializationAndDeserialization = new SerializationDeserialization();
            serializationAndDeserialization.BinarySerialization();
            serializationAndDeserialization.BinaryDeserialization();
            serializationAndDeserialization.JsonSerialization();
            serializationAndDeserialization.JsonDeSerialization();
            serializationAndDeserialization.XMLSerialize();
            serializationAndDeserialization.XmlDeSerialization();
        }

        public static void FileExists() 
        {
            string path = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\example.txt";
            if (File.Exists(path)) Console.WriteLine("File Exists");

        }

        public static void ReadAllLines() 
        {
            string path = @"C:\Users\Aayush Arya\source\repos\FileIODemo\FileIODemo\TxtFolder\example.txt";
            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines) 
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(lines[0]);
        }
    }
}
