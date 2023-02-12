using System;
using System.IO;

class FileWriter
{
    public static void Main()
    {
        string filePath = @"/Users/mille/SkillFactory/student.txt";
        if(!File.Exists(filePath))
        {
            using(StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("Юлия");
                sw.WriteLine("Андрей");
                sw.WriteLine("Артем");
            }
        }
        using (StreamReader sr = File.OpenText(filePath))
        {
            string str = "";
            while((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
    }
}