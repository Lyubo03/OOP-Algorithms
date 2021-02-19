using System;
using System.Linq;
using System.IO;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string docPath = @".\Citat.odt";
            string pathToCreateDocument = @".\document.txt";
            using FileStream streamFile = new FileStream(docPath, FileMode.Open,FileAccess.ReadWrite);
            using FileStream writeDoc = new FileStream(pathToCreateDocument, FileMode.OpenOrCreate);
            byte[] buffer = new byte[1000];
            while (true)
            {
                int totalBytes = streamFile.Read(buffer, 0, buffer.Length);
                if (buffer.Length > totalBytes)
                {
                    writeDoc.Write(buffer, 0, totalBytes);
                    break;
                }
                writeDoc.Write(buffer, 0, buffer.Length);
            }
        }
    }
}