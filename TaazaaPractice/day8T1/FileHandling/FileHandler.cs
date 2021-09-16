using System;
using System.IO;
namespace day8T1.FileHandling
{
    public class FileHandler
    {
        public void WriteToFile(string name)
        {
            FileStream F = new FileStream("Training.txt", FileMode.Open);
            StreamWriter stringWriter=new StreamWriter(F);
            stringWriter.WriteLine(name);
            Console.WriteLine("File Created");
            stringWriter.Close();
            F.Close();
        }
        public void Readfromfile()
        {
            FileStream F = new FileStream("Training.txt", FileMode.Open);
            StreamReader streamReader=new StreamReader(F);   
            string fileData=streamReader.ReadLine();
            Console.WriteLine(fileData);
            streamReader.Close();
            F.Close();
        }
    }
}